
namespace negozioLibri_server
{
    partial class frmServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.numUpDownPrezzo = new System.Windows.Forms.NumericUpDown();
            this.btnMettiInVendita = new System.Windows.Forms.Button();
            this.rTxtDescrizione = new System.Windows.Forms.RichTextBox();
            this.txtCodiceISBN = new System.Windows.Forms.TextBox();
            this.txtLingua = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblCodiceISBN = new System.Windows.Forms.Label();
            this.lblLingua = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.picBoxFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblVendi = new System.Windows.Forms.Label();
            this.btnAttivaServer = new System.Windows.Forms.Button();
            this.pnlServer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            this.pnlServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(431, 7);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(131, 35);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // numUpDownPrezzo
            // 
            this.numUpDownPrezzo.DecimalPlaces = 1;
            this.numUpDownPrezzo.Location = new System.Drawing.Point(721, 154);
            this.numUpDownPrezzo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownPrezzo.Name = "numUpDownPrezzo";
            this.numUpDownPrezzo.Size = new System.Drawing.Size(147, 20);
            this.numUpDownPrezzo.TabIndex = 30;
            this.numUpDownPrezzo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMettiInVendita
            // 
            this.btnMettiInVendita.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMettiInVendita.FlatAppearance.BorderSize = 0;
            this.btnMettiInVendita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettiInVendita.ForeColor = System.Drawing.Color.White;
            this.btnMettiInVendita.Location = new System.Drawing.Point(506, 281);
            this.btnMettiInVendita.Name = "btnMettiInVendita";
            this.btnMettiInVendita.Size = new System.Drawing.Size(118, 23);
            this.btnMettiInVendita.TabIndex = 29;
            this.btnMettiInVendita.Text = "Metti in vendita";
            this.btnMettiInVendita.UseVisualStyleBackColor = false;
            this.btnMettiInVendita.Click += new System.EventHandler(this.btnMettiInVendita_Click);
            // 
            // rTxtDescrizione
            // 
            this.rTxtDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtDescrizione.Location = new System.Drawing.Point(362, 154);
            this.rTxtDescrizione.Name = "rTxtDescrizione";
            this.rTxtDescrizione.Size = new System.Drawing.Size(230, 60);
            this.rTxtDescrizione.TabIndex = 28;
            this.rTxtDescrizione.Text = "";
            // 
            // txtCodiceISBN
            // 
            this.txtCodiceISBN.Location = new System.Drawing.Point(721, 109);
            this.txtCodiceISBN.Name = "txtCodiceISBN";
            this.txtCodiceISBN.Size = new System.Drawing.Size(147, 20);
            this.txtCodiceISBN.TabIndex = 27;
            this.txtCodiceISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodiceISBN_KeyPress);
            // 
            // txtLingua
            // 
            this.txtLingua.Location = new System.Drawing.Point(362, 113);
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.Size = new System.Drawing.Size(230, 20);
            this.txtLingua.TabIndex = 26;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(721, 70);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(147, 20);
            this.txtMateria.TabIndex = 25;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(666, 156);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 24;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(294, 154);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(62, 13);
            this.lblDescrizione.TabIndex = 23;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblCodiceISBN
            // 
            this.lblCodiceISBN.AutoSize = true;
            this.lblCodiceISBN.Location = new System.Drawing.Point(663, 114);
            this.lblCodiceISBN.Name = "lblCodiceISBN";
            this.lblCodiceISBN.Size = new System.Drawing.Size(39, 13);
            this.lblCodiceISBN.TabIndex = 22;
            this.lblCodiceISBN.Text = "ISBN *";
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(294, 116);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(39, 13);
            this.lblLingua.TabIndex = 21;
            this.lblLingua.Text = "Lingua";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(663, 75);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(49, 13);
            this.lblMateria.TabIndex = 20;
            this.lblMateria.Text = "Materia *";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(362, 74);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(230, 20);
            this.txtTitolo.TabIndex = 19;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(294, 77);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(40, 13);
            this.lblTitolo.TabIndex = 18;
            this.lblTitolo.Text = "Titolo *";
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFoto.Image")));
            this.picBoxFoto.Location = new System.Drawing.Point(25, 98);
            this.picBoxFoto.Name = "picBoxFoto";
            this.picBoxFoto.Size = new System.Drawing.Size(185, 206);
            this.picBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFoto.TabIndex = 17;
            this.picBoxFoto.TabStop = false;
            this.picBoxFoto.Click += new System.EventHandler(this.picBoxFoto_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(49, 64);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 18);
            this.lblFoto.TabIndex = 16;
            this.lblFoto.Text = "Foto";
            // 
            // lblVendi
            // 
            this.lblVendi.AutoSize = true;
            this.lblVendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendi.Location = new System.Drawing.Point(48, 14);
            this.lblVendi.Name = "lblVendi";
            this.lblVendi.Size = new System.Drawing.Size(60, 24);
            this.lblVendi.TabIndex = 31;
            this.lblVendi.Text = "Vendi";
            // 
            // btnAttivaServer
            // 
            this.btnAttivaServer.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAttivaServer.FlatAppearance.BorderSize = 0;
            this.btnAttivaServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttivaServer.ForeColor = System.Drawing.Color.White;
            this.btnAttivaServer.Location = new System.Drawing.Point(444, 59);
            this.btnAttivaServer.Name = "btnAttivaServer";
            this.btnAttivaServer.Size = new System.Drawing.Size(102, 23);
            this.btnAttivaServer.TabIndex = 32;
            this.btnAttivaServer.Text = "Attiva server";
            this.btnAttivaServer.UseVisualStyleBackColor = false;
            this.btnAttivaServer.Click += new System.EventHandler(this.btnAttivaServer_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.Controls.Add(this.btnMettiInVendita);
            this.pnlServer.Controls.Add(this.picBoxFoto);
            this.pnlServer.Controls.Add(this.lblVendi);
            this.pnlServer.Controls.Add(this.rTxtDescrizione);
            this.pnlServer.Controls.Add(this.lblFoto);
            this.pnlServer.Controls.Add(this.numUpDownPrezzo);
            this.pnlServer.Controls.Add(this.lblTitolo);
            this.pnlServer.Controls.Add(this.txtTitolo);
            this.pnlServer.Controls.Add(this.txtCodiceISBN);
            this.pnlServer.Controls.Add(this.lblMateria);
            this.pnlServer.Controls.Add(this.txtLingua);
            this.pnlServer.Controls.Add(this.lblLingua);
            this.pnlServer.Controls.Add(this.txtMateria);
            this.pnlServer.Controls.Add(this.lblCodiceISBN);
            this.pnlServer.Controls.Add(this.lblPrezzo);
            this.pnlServer.Controls.Add(this.lblDescrizione);
            this.pnlServer.Location = new System.Drawing.Point(35, 88);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(910, 334);
            this.pnlServer.TabIndex = 33;
            this.pnlServer.Visible = false;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 476);
            this.Controls.Add(this.pnlServer);
            this.Controls.Add(this.btnAttivaServer);
            this.Controls.Add(this.picBoxLogo);
            this.Name = "frmServer";
            this.Text = "Books24 - Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            this.pnlServer.ResumeLayout(false);
            this.pnlServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.NumericUpDown numUpDownPrezzo;
        private System.Windows.Forms.Button btnMettiInVendita;
        private System.Windows.Forms.RichTextBox rTxtDescrizione;
        private System.Windows.Forms.TextBox txtCodiceISBN;
        private System.Windows.Forms.TextBox txtLingua;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblCodiceISBN;
        private System.Windows.Forms.Label lblLingua;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.PictureBox picBoxFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblVendi;
        private System.Windows.Forms.Button btnAttivaServer;
        private System.Windows.Forms.Panel pnlServer;
    }
}

