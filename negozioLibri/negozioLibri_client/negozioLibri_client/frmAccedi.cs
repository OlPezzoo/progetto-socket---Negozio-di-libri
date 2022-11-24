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
    public partial class frmAccedi : Form
    {
        public frmAccedi()
        {
            InitializeComponent();
        }

        private void frmAccedi_Load(object sender, EventArgs e)
        {

        }

        public void login(ref bool r)
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
                    stringa_da_inviare = "na " + txtUsername_accedi.Text + ";" + mTxtPassword_accedi.Text + "$";
                    byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                    int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
                    data = "";

                    int bytesRec = sender.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data == "successful")
                    {
                        r = true;
                        MessageBox.Show("Ciao, " + txtUsername_accedi.Text);
                    }
                    else if (data == "failed")
                    {
                        MessageBox.Show("Credenziali non valide.");
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

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtUsername_accedi.Text != "" && mTxtPassword_accedi.Text != "")
            {
                bool r = false;
                login(ref r);
                if (r == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Devi compilare entrambi i campi.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrazione frmReg = new frmRegistrazione();
            frmReg.ShowDialog();
            this.Close();
        }
    }
}
