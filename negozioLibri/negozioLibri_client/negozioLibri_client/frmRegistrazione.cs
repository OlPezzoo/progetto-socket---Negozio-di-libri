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
    public partial class frmRegistrazione : Form
    {
        byte[] bytes = frmHome.bytes;
        Socket sender = frmHome.sender;
        string data = frmHome.data;
        string stringa_da_inviare = frmHome.stringa_da_inviare;

        public frmRegistrazione()
        {
            InitializeComponent();
        }

        private void frmRegistrazione_Load(object sender, EventArgs e)
        {

        }

        public void aggiungiUtente(ref bool r)
        {
            try
            {
                stringa_da_inviare = "nr " + txtUsername.Text + ";" + mTxtPassword.Text + ";" + txtCodiceFiscale.Text + ";" + txtMail.Text + ";" + txtCell.Text + "$";
                byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
                data = "";

                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data == "successful")
                {
                    r = true;
                    MessageBox.Show("Registrazione completata.");
                }
                else if (data == "failed")
                {
                    MessageBox.Show("Il codice fiscale inserito è già associato ad un utente.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
			if (txtUsername.Text != "" && mTxtPassword.Text != "" && txtCodiceFiscale.Text != "" && txtMail.Text != "" && txtCell.Text != "")
            {
                bool r = false;
                aggiungiUtente(ref r);
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
    }
}
