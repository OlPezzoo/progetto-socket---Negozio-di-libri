
namespace negozioLibri_client
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUtente = new System.Windows.Forms.Button();
            this.btnLogoHome = new System.Windows.Forms.Button();
            this.flPanelLibri = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnUtente
            // 
            this.btnUtente.BackColor = System.Drawing.Color.White;
            this.btnUtente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUtente.BackgroundImage")));
            this.btnUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUtente.FlatAppearance.BorderSize = 0;
            this.btnUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtente.ForeColor = System.Drawing.Color.Black;
            this.btnUtente.Location = new System.Drawing.Point(738, 23);
            this.btnUtente.Name = "btnUtente";
            this.btnUtente.Size = new System.Drawing.Size(33, 31);
            this.btnUtente.TabIndex = 10;
            this.btnUtente.UseVisualStyleBackColor = false;
            this.btnUtente.Click += new System.EventHandler(this.btnUtente_Click);
            // 
            // btnLogoHome
            // 
            this.btnLogoHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoHome.BackgroundImage")));
            this.btnLogoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogoHome.FlatAppearance.BorderSize = 0;
            this.btnLogoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoHome.Location = new System.Drawing.Point(28, 12);
            this.btnLogoHome.Name = "btnLogoHome";
            this.btnLogoHome.Size = new System.Drawing.Size(93, 41);
            this.btnLogoHome.TabIndex = 13;
            this.btnLogoHome.UseVisualStyleBackColor = true;
            this.btnLogoHome.Click += new System.EventHandler(this.btnLogoHome_Click);
            // 
            // flPanelLibri
            // 
            this.flPanelLibri.AutoScroll = true;
            this.flPanelLibri.Location = new System.Drawing.Point(28, 119);
            this.flPanelLibri.Name = "flPanelLibri";
            this.flPanelLibri.Size = new System.Drawing.Size(743, 331);
            this.flPanelLibri.TabIndex = 14;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAggiorna.FlatAppearance.BorderSize = 0;
            this.btnAggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiorna.ForeColor = System.Drawing.Color.White;
            this.btnAggiorna.Location = new System.Drawing.Point(335, 80);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(123, 23);
            this.btnAggiorna.TabIndex = 15;
            this.btnAggiorna.Text = "Aggiorna risultati";
            this.btnAggiorna.UseVisualStyleBackColor = false;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(518, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(17, 24);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.flPanelLibri);
            this.Controls.Add(this.btnLogoHome);
            this.Controls.Add(this.btnUtente);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUtente;
        private System.Windows.Forms.Button btnLogoHome;
        private System.Windows.Forms.FlowLayoutPanel flPanelLibri;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnCancel;
    }
}

