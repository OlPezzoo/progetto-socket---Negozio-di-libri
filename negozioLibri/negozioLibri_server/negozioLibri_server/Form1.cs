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
using System.Windows.Forms;

namespace negozioLibri_server
{
    public partial class frmServer : Form
    {
        List<Libro> libri = new List<Libro>();

        //PROVA

        public frmServer()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void startListening()
        {
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            //creo un socket TCP
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //il socket viene associato alla porta e aspetta una connessione da parte di un client
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    //attende finché non avviene una connessione
                    listBoxAttivita.Items.Add("In attesa di connessione...");
                    //all'arrivo di una connessione, viene creato un nuovo socket per essa
                    Socket handler = listener.Accept();

                    ClientManager clientThread = new ClientManager(handler);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool ricercaISBN()
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\..\..\elencoLibri.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[4] == txtCodiceISBN.Text)
                    {
                        t = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
            return t;
        }

        private void picBoxFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog addImageDialog = new OpenFileDialog();
            var filePath = string.Empty;
            if (addImageDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(addImageDialog.FileName);
                picBoxFoto.Image = img;
            }
        }

        private void btnMettiInVendita_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" && txtMateria.Text != "" && txtCodiceISBN.Text != "")
            {
                if (ricercaISBN() == false)
                {
                    MessageBox.Show("L'oggetto è stato messo in vendita!");
                    libri.Add(new Libro(picBoxFoto, txtTitolo.Text, txtMateria.Text, txtLingua.Text, txtCodiceISBN.Text, rTxtDescrizione.Text, numUpDownPrezzo.Value));

                    //scrittura su file
                    string path = @"..\..\..\..\elencoLibri.csv";
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(picBoxFoto + ";" + txtTitolo.Text + ";" + txtMateria.Text + ";" + txtLingua.Text + ";" + txtCodiceISBN.Text + ";" + rTxtDescrizione.Text + ";" + numUpDownPrezzo.Value);
                    }

                    picBoxFoto.Image = Image.FromFile(@"..\..\..\..\imgAddPhoto.png");
                    txtTitolo.Text = "";
                    txtMateria.Text = "";
                    txtLingua.Text = "";
                    txtCodiceISBN.Text = "";
                    rTxtDescrizione.Text = "";
                    numUpDownPrezzo.Value = numUpDownPrezzo.Minimum;
                }
                else
                {
                    MessageBox.Show("Il codice ISBN inserito è già associato ad un libro.");
                }
            }
            else
            {
                MessageBox.Show("Devi compilare entrambi i campi.");
            }
        }

        private void btnAttivaServer_Click(object sender, EventArgs e)
        {
            btnAttivaServer.Hide();
            pnlServer.Show();
            Thread t = new Thread(new ThreadStart(startListening));
            t.Start();
        }
    }

    class ClientManager
    {
        Socket clientSocket;
        byte[] bytes = new Byte[1024]; //bytes a disposizione per i dati
        String data = "";

        public ClientManager(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        public void doClient()
        {
            while (data != "Quit$")
            {
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes); //vengono presi fino a 1024 byte del messaggio del socket client e messi nell'array bytes
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec); //concatena in data un carattere dopo l'altro, convertito in ASCII, dell'array bytes
                }
                byte[] msg = Encoding.ASCII.GetBytes(data); //converte la stringa passata per parametro in una sequenza di byte
                clientSocket.Send(msg); //il messaggio viene mandato al socket client
            }
            clientSocket.Shutdown(SocketShutdown.Both); //chiude la connessione sia del client che del server
            clientSocket.Close();
            data = "";
        }
    }

    class Libro
    {
        private PictureBox foto { get; set; }
        private string titolo { get; set; }
        private string materia { get; set; }
        private string lingua { get; set; }
        private string isbn { get; set; }
        private string descrizione { get; set; }
        private decimal prezzo { get; set; }

        public Libro(PictureBox foto, string titolo, string materia, string lingua, string isbn, string descrizione, decimal prezzo)
        {
            this.foto = foto;
            this.titolo = titolo;
            this.materia = materia;
            this.lingua = lingua;
            this.isbn = isbn;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
    }
}
