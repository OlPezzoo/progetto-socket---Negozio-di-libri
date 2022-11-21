using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private bool login()
        {
            bool t = false;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"..\..\..\..\elencoUtenti.csv"))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit[0] == txtUsername_accedi.Text && lineSplit[1] == mTxtPassword_accedi.Text)
                    {
                        t = true;
                        break;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Si è verificato un errore.");
            }
            return t;
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtUsername_accedi.Text != "" && mTxtPassword_accedi.Text != "")
            {
                if (login() == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenziali non valide.");
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
