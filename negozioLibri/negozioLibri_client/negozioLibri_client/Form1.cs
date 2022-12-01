using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
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

                    PictureBox pic = new PictureBox();
                    pic.Width = 150;
                    pic.Height = 150;
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    pic.Parent = flPanelLibri;

                    Label lblTitolo = new Label();
                    lblTitolo.Font = new Font("Arial", 12);
                    lblTitolo.Name = "lblTitolo_" + dataSplit[4]; //dataSplit[4] = ISBN
                    lblTitolo.Text = dataSplit[1];
                    lblTitolo.AutoSize = true;
                    lblTitolo.Dock = DockStyle.Bottom;

                    Label lblPrezzo = new Label();
                    lblPrezzo.Name = "lblPrezzo_" + dataSplit[4];
                    lblPrezzo.Text = "€" + dataSplit[6];
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
            frmLibro formLibro = new frmLibro(dataSplit[0], dataSplit[1], dataSplit[2], dataSplit[3], dataSplit[4], dataSplit[5], dataSplit[6]);
            formLibro.ShowDialog();
        }

        public void acquista()
        {
            try
            {
                stringa_da_inviare = "buy "; //da specificare anche l'ISBN
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg);
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data == "successful")
                {
                    MessageBox.Show("Libro acquistato!");
                }
                else if (data == "failed")
                {
                    MessageBox.Show("Il libro non è disponibile.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
        }

        private void btnUtente_Click(object sender, EventArgs e)
        {
            frmAccedi frmAcc = new frmAccedi();
            frmAcc.ShowDialog();
        }

        public void cerca(ref bool r)
        {
            try
            {
                stringa_da_inviare = "src " + txtSearch.Text + "$";
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data == "successful")
                {
                    r = true;
                }
                else if (data == "failed")
                {
                    MessageBox.Show("La tua ricerca non ha prodotto risultati.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
        }

        private void eseguiRicerca()
        {
            bool r = false;
            cerca(ref r);
            if (r == true)
            {
                this.Close();
            }
        }

        private void btnLente_Click(object sender, EventArgs e)
        {
            
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

        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            flPanelLibri.Controls.Clear();
            listen();
        }
    }
}
