
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
            this.btnCarrello = new System.Windows.Forms.Button();
            this.btnLente = new System.Windows.Forms.Button();
            this.btnLogoHome = new System.Windows.Forms.Button();
            this.flPanelLibri = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 9;
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
            // btnCarrello
            // 
            this.btnCarrello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarrello.BackgroundImage")));
            this.btnCarrello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarrello.FlatAppearance.BorderSize = 0;
            this.btnCarrello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrello.Location = new System.Drawing.Point(687, 23);
            this.btnCarrello.Name = "btnCarrello";
            this.btnCarrello.Size = new System.Drawing.Size(32, 27);
            this.btnCarrello.TabIndex = 11;
            this.btnCarrello.UseVisualStyleBackColor = true;
            this.btnCarrello.Click += new System.EventHandler(this.btnCarrello_Click);
            // 
            // btnLente
            // 
            this.btnLente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLente.BackgroundImage")));
            this.btnLente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLente.FlatAppearance.BorderSize = 0;
            this.btnLente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLente.Location = new System.Drawing.Point(518, 30);
            this.btnLente.Name = "btnLente";
            this.btnLente.Size = new System.Drawing.Size(19, 20);
            this.btnLente.TabIndex = 12;
            this.btnLente.UseVisualStyleBackColor = true;
            this.btnLente.Click += new System.EventHandler(this.btnLente_Click);
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
            this.flPanelLibri.Location = new System.Drawing.Point(28, 101);
            this.flPanelLibri.Name = "flPanelLibri";
            this.flPanelLibri.Size = new System.Drawing.Size(743, 310);
            this.flPanelLibri.TabIndex = 14;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flPanelLibri);
            this.Controls.Add(this.btnLogoHome);
            this.Controls.Add(this.btnLente);
            this.Controls.Add(this.btnCarrello);
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
        private System.Windows.Forms.Button btnCarrello;
        private System.Windows.Forms.Button btnLente;
        private System.Windows.Forms.Button btnLogoHome;
        private System.Windows.Forms.FlowLayoutPanel flPanelLibri;
    }
}

