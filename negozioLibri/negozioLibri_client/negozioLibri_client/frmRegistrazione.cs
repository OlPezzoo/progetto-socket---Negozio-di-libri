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
		List<Utente> utenti = new List<Utente>();

        public frmRegistrazione()
        {
            InitializeComponent();
        }

        private void frmRegistrazione_Load(object sender, EventArgs e)
        {

        }

		private bool ricercaCF()
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\..\..\elencoUtenti.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[2] == txtCodiceFiscale.Text)
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

        public void aggiungiUtente(string user, string pw, string cf, string mail, string cell)
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
                    //MessageBox.Show("Connesso con " + sender.RemoteEndPoint.ToString());
                    stringa_da_inviare = "Registrazione utente " + user + " (password: " + pw + "; CF: " + cf + "; email: " + mail + "; cellulare: " + cell + ")" + "$";
                    byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
                    int bytesSent = sender.Send(msg); //invio il messaggio attraverso il socket
                    data = "";

                    //ricevo la risposta dal server
                    while (data.IndexOf("$") == -1)
                    {
                        int bytesRec = sender.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
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

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
			if (txtUsername.Text != "" && mTxtPassword.Text != "" && txtCodiceFiscale.Text != "" && txtMail.Text != "" && txtCell.Text != "")
            {
				if (ricercaCF() == false)
                {
					MessageBox.Show("Registrazione effettuata con successo.");
					utenti.Add(new Utente(txtUsername.Text, mTxtPassword.Text, txtCodiceFiscale.Text, txtMail.Text, txtCell.Text));
                    aggiungiUtente(txtUsername.Text, mTxtPassword.Text, txtCodiceFiscale.Text, txtMail.Text, txtCell.Text);

					//scrittura su file
					string path = @"..\..\..\..\elencoUtenti.csv";
					using (StreamWriter sw = File.AppendText(path))
					{
						sw.WriteLine(txtUsername.Text + ";" + mTxtPassword.Text + ";" + txtCodiceFiscale.Text + ";" + txtMail.Text + ";" + txtCell.Text);
					}
					this.Close();
				}
				else
                {
					MessageBox.Show("Il codice fiscale inserito è già associato ad un utente.");
                }
			}
			else
			{
				MessageBox.Show("Devi compilare entrambi i campi.");
			}
		}
    }

	class Utente
	{
		private string username { get; set; }
		private string password { get; set; }
		private string codiceFiscale { get; set; }
		private string mail { get; set; }
		private string cell { get; set; }

		public Utente(string username, string password, string codiceFiscale, string mail, string cell)
        {
			this.username = username;
			this.password = password;
			this.codiceFiscale = codiceFiscale;
			this.mail = mail;
			this.cell = cell;
        }
	}
}
