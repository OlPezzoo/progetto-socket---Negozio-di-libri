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
        public static string data = null; //dati in arrivo dal client
        public static IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        public static IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

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
                    //all'arrivo di una connessione, viene creato un nuovo socket per essa
                    Socket handler = listener.Accept();

                    ClientManager clientThread = new ClientManager(handler);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private bool ricercaISBN()
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\elencoLibri.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[4] == txtCodiceISBN.Text)
                    {
                        t = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
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

        public bool ricercaCF(string cf)
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\elencoUtenti.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[2] == cf)
                    {
                        t = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return t;
        }

        public bool login(string usr, string pwd)
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\elencoUtenti.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[0] == usr && lineSplit[1] == pwd)
                    {
                        t = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return t;
        }

        private void btnMettiInVendita_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" && txtMateria.Text != "" && txtCodiceISBN.Text != "")
            {
                if (ricercaISBN() == false)
                {
                    MessageBox.Show("L'oggetto è stato messo in vendita!");

                    //scrittura su file
                    string path = @"..\..\elencoLibri.csv";
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(picBoxFoto + ";" + txtTitolo.Text + ";" + txtMateria.Text + ";" + txtLingua.Text + ";" + txtCodiceISBN.Text + ";" + rTxtDescrizione.Text + ";" + numUpDownPrezzo.Value);
                    }

                    picBoxFoto.Image = Image.FromFile(@"..\..\imgAddPhoto.png");
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
                MessageBox.Show("Devi compilare tutti i campi necessari.");
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
        frmServer formServer = new frmServer();
        Socket clientSocket;
        byte[] bytes = new Byte[1024]; //bytes a disposizione per i dati
        String data = "";
        List<string> fileLines = new List<string>();
        List<string> isbnRm = new List<string>();

        public ClientManager(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        public void doClient()
        {
            try
            {
                while (data != "Quit$")
                {
                    data = "";
                    //viene decifrato il messaggio
                    while (data.IndexOf("$") == -1)
                    {
                        int bytesRec = clientSocket.Receive(bytes); //vengono presi fino a 1024 byte del messaggio del socket client e messi nell'array bytes
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec); //concatena in data un carattere dopo l'altro, convertito in ASCII, dell'array bytes
                    }
                    byte[] msg = Encoding.ASCII.GetBytes("");

                    if (data.StartsWith("nr "))
                    {
                        data = data.Remove(0, 3); //elimino la parte iniziale "nr "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"
                        string[] dataSplit = data.Split(';');

                        if (formServer.ricercaCF(dataSplit[2]) == false)
                        {
                            string path = @"..\..\elencoUtenti.csv";
                            using (StreamWriter sw = File.AppendText(path))
                            {
                                sw.WriteLine(data);
                            }
                            msg = Encoding.ASCII.GetBytes("successful");
                        }
                        else
                        {
                            msg = Encoding.ASCII.GetBytes("failed");
                        }
                        clientSocket.Send(msg);
                    }
                    else if (data.StartsWith("na "))
                    {
                        data = data.Remove(0, 3); //elimino la parte iniziale "na "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"
                        string[] dataSplit = data.Split(';');

                        if (formServer.login(dataSplit[0], dataSplit[1]) == true)
                        {
                            msg = Encoding.ASCII.GetBytes("successful");
                        }
                        else
                        {
                            msg = Encoding.ASCII.GetBytes("failed");
                        }
                        clientSocket.Send(msg);
                    }
                    else if (data.StartsWith("numRm "))
                    {
                        data = data.Remove(0, 6); //elimino la parte iniziale "numRm "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"

                        isbnRm.Clear();
                        int count = 0;
                        foreach (string fl in System.IO.File.ReadAllLines(@"..\..\elencoLibri.csv"))
                        {
                            string[] lineSplit = fl.Split(';');
                            if (!(lineSplit[1].StartsWith(data))) //lineSplit[1] --> titolo
                            {
                                isbnRm.Add(lineSplit[4]);
                                count++;
                            }
                        }
                        msg = Encoding.ASCII.GetBytes("numRm " + count.ToString());
                        clientSocket.Send(msg);
                    }
                    else if (data.StartsWith("rm "))
                    {
                        data = data.Remove(0, 3); //elimino la parte iniziale "rm "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"
                        msg = Encoding.ASCII.GetBytes("rm " + isbnRm[Int32.Parse(data)]);
                        clientSocket.Send(msg);
                    }
                    else if (data.StartsWith("buy "))
                    {
                        data = data.Remove(0, 4); //elimino la parte iniziale "buy "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"

                        try
                        {
                            foreach (string line in System.IO.File.ReadAllLines(@"..\..\elencoLibri.csv"))
                            {
                                string[] lineSplit = line.Split(';');
                                if (lineSplit[4] == data)
                                {
                                    fileLines.Remove(line);
                                    msg = Encoding.ASCII.GetBytes("successful");

                                    File.WriteAllText(@"..\..\elencoLibri.csv", ""); //il file viene svuotato
                                    //il file viene riscritto
                                    foreach (string fl in fileLines)
                                    {
                                        File.AppendAllText(@"..\..\elencoLibri.csv", fl + "\n");
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            msg = Encoding.ASCII.GetBytes("failed");
                        }
                        clientSocket.Send(msg);
                    }
                    else if (data == "numl$")
                    {
                        fileLines.Clear();
                        int nl = 0;
                        foreach (string line in System.IO.File.ReadAllLines(@"..\..\elencoLibri.csv"))
                        {
                            fileLines.Add(line);
                            nl++;
                        }
                        msg = Encoding.ASCII.GetBytes("numl " + nl.ToString());
                        clientSocket.Send(msg);
                    }
                    else if (data.StartsWith("line "))
                    {
                        data = data.Remove(0, 5); //elimino la parte iniziale "line "
                        data = data.Remove(data.Length - 1); //elimino la parte finale "$"
                        msg = Encoding.ASCII.GetBytes("line " + fileLines[Int32.Parse(data)]);
                        clientSocket.Send(msg);
                    }
                }
                clientSocket.Shutdown(SocketShutdown.Both); //chiude la connessione sia del client che del server
                clientSocket.Close();
                data = "";
            }
            catch(SocketException)
            {
                Console.WriteLine("SocketException");
            }
        }
    }
}
