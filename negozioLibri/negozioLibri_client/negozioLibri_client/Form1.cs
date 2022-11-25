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
using System.Windows.Forms;

namespace negozioLibri_client
{
    public partial class frmHome : Form
    {
        byte[] bytes = new byte[1024]; //bytes a disposizione per i dati
        Socket sender;
        string data;
        string stringa_da_inviare;

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
                    MessageBox.Show("Sei connesso!");
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void listen()
        {
            stringa_da_inviare = "l$";
            byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
            int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
            data = "";

            int bytesRec = sender.Receive(bytes);
            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            if (data.StartsWith("lr "))
            {
                //aggiungo elementi a flPanelLibri
                lblLibroProva.Text = data;
            }
        }


        private void btnUtente_Click(object sender, EventArgs e)
        {
            frmAccedi frmAcc = new frmAccedi();
            frmAcc.ShowDialog();
        }

        private void btnCarrello_Click(object sender, EventArgs e)
        {

        }

        public void cerca(ref bool r)
        {
            byte[] bytes = new byte[1024]; //bytes a disposizione per i dati

            try
            {
                string data = "";
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Creo un socket TCP
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                string stringa_da_inviare = "";

                try
                {
                    sender.Connect(remoteEP);
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

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
    }
}
