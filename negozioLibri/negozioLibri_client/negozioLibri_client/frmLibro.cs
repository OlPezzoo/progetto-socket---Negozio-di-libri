using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace negozioLibri_client
{
    public partial class frmLibro : Form
    {
        string titolo = "-";
        string materia = "-";
        string lingua = "-";
        string isbn = "-";
        string descrizione = "-";
        string prezzo = "-";

        byte[] bytes = frmHome.bytes;
        Socket sender = frmHome.sender;
        string data = frmHome.data;
        string stringa_da_inviare = frmHome.stringa_da_inviare;
        bool acc = frmAccedi.logged;
        bool reg = frmRegistrazione.logged;

        public frmLibro(string titolo, string materia, string lingua, string isbn, string descrizione, string prezzo)
        {
            InitializeComponent();
            this.titolo = titolo;
            this.materia = materia;
            this.lingua = lingua;
            this.isbn = isbn;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            titoloValue.Text = titolo;
            materiaValue.Text = materia;
            linguaValue.Text = lingua;
            isbnValue.Text = isbn;
            descrizioneValue.Text = descrizione;
            prezzoValue.Text = prezzo;
        }

        private void acquista()
        {
            stringa_da_inviare = "buy " + isbnValue.Text + "$";
            byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);
            int bytesSent = sender.Send(msg);
            data = "";

            int bytesRec = sender.Receive(bytes);
            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            if (data == "successful")
            {
                MessageBox.Show("Acquisto effettuato con successo!");
            }
            else if (data == "failed")
            {
                MessageBox.Show("Questo libro non è disponibile.");
            }
        }


        private void btnAcquista_Click(object sender, EventArgs e)
        {
            if (acc == true || reg == true)
            {
                acquista();
                frmHome formHome = new frmHome();
                formHome.listen();
                this.Close();
            }
            else
            {
                MessageBox.Show("Per poter acquistare libri devi effettuare l'accesso.");
            }
        }
    }
}
