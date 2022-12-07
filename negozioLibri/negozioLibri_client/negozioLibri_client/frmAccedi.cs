using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace negozioLibri_client
{
    public partial class frmAccedi : Form
    {
        public static bool logged = false;
        byte[] bytes = frmHome.bytes;
        Socket sender = frmHome.sender;
        string data = frmHome.data;
        string stringa_da_inviare = frmHome.stringa_da_inviare;

        public frmAccedi()
        {
            InitializeComponent();
        }

        private void frmAccedi_Load(object sender, EventArgs e)
        {

        }

        public void login(ref bool l)
        {
            try
            {
                stringa_da_inviare = "na " + txtUsername_accedi.Text + ";" + mTxtPassword_accedi.Text + "$";
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data == "successful")
                {
                    l = true;
                    MessageBox.Show("Ciao " + txtUsername_accedi.Text);
                }
                else if (data == "failed")
                {
                    MessageBox.Show("Credenziali non valide.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtUsername_accedi.Text != "" && mTxtPassword_accedi.Text != "")
            {
                login(ref logged);
                if (logged == true)
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
