using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
			if (txtUsername.Text != "" && mTxtPassword.Text != "" && txtCodiceFiscale.Text != "" && txtMail.Text != "" && txtCell.Text != "")
            {
				if (ricercaCF() == false)
                {
					MessageBox.Show("Registrazione effettuata con successo.");
					utenti.Add(new Utente(txtUsername.Text, mTxtPassword.Text, txtCodiceFiscale.Text, txtMail.Text, txtCell.Text));

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
