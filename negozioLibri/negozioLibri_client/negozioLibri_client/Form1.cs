using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negozioLibri_client
{
    public partial class frmHome : Form
    {
        public static byte[] bytes = new byte[1024]; //bytes a disposizione per i dati
        public static Socket sender;
        public static string data;
        public static string stringa_da_inviare;
        string[] dataSplit;
        List<Libro> libri = new List<Libro>();

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            connessione();
            listen();
        }

        public void connessione()
        {
            try
            {
                data = "";
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Creo un socket TCP
                sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                stringa_da_inviare = "";

                try
                {
                    sender.Connect(remoteEP);
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
        }

        public void listen()
        {
            try
            {
                libri.Clear();
                stringa_da_inviare = "numl$";
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg);
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                data = data.Remove(0, 5); //elimino la parte iniziale "numl "
                int nl = Int32.Parse(data);

                for (int i = 0; i < nl; i++)
                {
                    stringa_da_inviare = "line " + i + "$";
                    msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                    bytesSent = sender.Send(msg);
                    data = "";

                    bytesRec = sender.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    data = data.Remove(0, 5); //elimino la parte iniziale "line "
                    dataSplit = data.Split(';');
                    libri.Add(new Libro(dataSplit[0], dataSplit[1], dataSplit[2], dataSplit[3], dataSplit[4], dataSplit[5]));

                    PictureBox pic = new PictureBox();
                    pic.Width = 150;
                    pic.Height = 150;
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    pic.BackgroundImage = Image.FromFile(@"..\..\imgLibro.png");
                    pic.Parent = flPanelLibri;
                    pic.Name = "pic_" + i.ToString();

                    Label lblTitolo = new Label();
                    lblTitolo.Font = new Font("Arial", 12);
                    lblTitolo.Name = "lblTitolo_" + dataSplit[3]; //dataSplit[4] --> ISBN
                    lblTitolo.Text = dataSplit[0];
                    lblTitolo.AutoSize = true;
                    lblTitolo.Dock = DockStyle.Bottom;

                    Label lblPrezzo = new Label();
                    lblPrezzo.Name = "lblPrezzo_" + dataSplit[3];
                    lblPrezzo.Text = "€" + dataSplit[5];
                    lblPrezzo.Width = 50;

                    pic.Controls.Add(lblTitolo);
                    pic.Controls.Add(lblPrezzo);
                    flPanelLibri.Controls.Add(pic);
                    pic.Cursor = Cursors.Hand;
                    pic.Click += new EventHandler(picClick);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
        }

        private void picClick(object sender, EventArgs e)
        {
            string senderName = ((PictureBox)sender).Name; //casting del nome della PictureBox
            string[] senderNameSplit = senderName.Split('_');
            int indice = Int32.Parse(senderNameSplit[1]);
            frmLibro formLibro = new frmLibro(libri[indice].titolo, libri[indice].materia, libri[indice].lingua, libri[indice].isbn, libri[indice].descrizione, libri[indice].prezzo);
            formLibro.ShowDialog();
        }

        private void btnUtente_Click(object sender, EventArgs e)
        {
            frmAccedi frmAcc = new frmAccedi();
            frmAcc.ShowDialog();
        }

        private void cerca()
        {
            try
            {
                stringa_da_inviare = "numRm " + txtSearch.Text + "$";
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg);
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                data = data.Remove(0, 6); //elimino la parte iniziale "numRm "
                int count = Int32.Parse(data);

                if (count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        stringa_da_inviare = "rm " + i + "$";
                        msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                        bytesSent = sender.Send(msg);
                        data = "";

                        bytesRec = sender.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        data = data.Remove(0, 3); //elimino la parte iniziale "rm "

                        string nameLabel = "lblTitolo_" + data;
                        foreach (PictureBox p in flPanelLibri.Controls)
                        {
                            foreach (Label lbl in p.Controls)
                            {
                                if (lbl.Name == nameLabel)
                                {
                                    flPanelLibri.Controls.Remove(p);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btnLogoHome_Click(object sender, EventArgs e)
        {
            frmHome_Load(sender, e);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtSearch.Text)))
            {
                cerca();
            }
            else
            {
                flPanelLibri.Controls.Clear();
                listen();
            }
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            flPanelLibri.Controls.Clear();
            listen();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }

    class Libro
    {
        public string titolo { get; set; }
        public string materia { get; set; }
        public string lingua { get; set; }
        public string isbn { get; set; }
        public string descrizione { get; set; }
        public string prezzo { get; set; }

        public Libro(string titolo, string materia, string lingua, string isbn, string descrizione, string prezzo)
        {
            this.titolo = titolo;
            this.materia = materia;
            this.lingua = lingua;
            this.isbn = isbn;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
    }
}
