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
    public partial class frmLibro : Form
    {
        string foto = "-";
        string titolo = "-";
        string lingua = "-";
        string descrizione = "-";
        string materia = "-";
        string isbn = "-";
        string prezzo = "-";

        public frmLibro(string foto, string titolo, string lingua, string descrizione, string materia, string isbn, string prezzo)
        {
            InitializeComponent();
            this.foto = foto;
            this.titolo = titolo;
            this.lingua = lingua;
            this.descrizione = descrizione;
            this.materia = materia;
            this.isbn = isbn;
            this.prezzo = prezzo;
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            //picFoto
            titoloValue.Text = titolo;
            linguaValue.Text = lingua;
            descrizioneValue.Text = descrizione;
            materiaValue.Text = materia;
            isbnValue.Text = isbn;
            prezzoValue.Text = prezzo;
        }

        private void btnAcquista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acquisto effettuato con successo!");
            this.Close();
        }
    }
}
