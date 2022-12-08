using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace negozioLibri_client
{
    public partial class frmRegistrazione : Form
    {
        public static bool logged = frmAccedi.logged;
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

        public void aggiungiUtente(ref bool l)
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
                    l = true;
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
                aggiungiUtente(ref logged);
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

        private void txtCodiceFiscale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void mTxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permette solo numeri
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
