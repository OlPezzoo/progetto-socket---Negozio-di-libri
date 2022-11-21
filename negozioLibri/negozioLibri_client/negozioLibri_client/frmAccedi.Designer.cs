
namespace negozioLibri_client
{
    partial class frmAccedi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccedi));
            this.btnAccedi = new System.Windows.Forms.Button();
            this.txtUsername_accedi = new System.Windows.Forms.TextBox();
            this.lblPassword_accedi = new System.Windows.Forms.Label();
            this.lblUsername_accedi = new System.Windows.Forms.Label();
            this.lblAccedi = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mTxtPassword_accedi = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccedi
            // 
            this.btnAccedi.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAccedi.FlatAppearance.BorderSize = 0;
            this.btnAccedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccedi.ForeColor = System.Drawing.Color.White;
            this.btnAccedi.Location = new System.Drawing.Point(125, 317);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(75, 23);
            this.btnAccedi.TabIndex = 13;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = false;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // txtUsername_accedi
            // 
            this.txtUsername_accedi.Location = new System.Drawing.Point(57, 173);
            this.txtUsername_accedi.Name = "txtUsername_accedi";
            this.txtUsername_accedi.Size = new System.Drawing.Size(149, 20);
            this.txtUsername_accedi.TabIndex = 11;
            // 
            // lblPassword_accedi
            // 
            this.lblPassword_accedi.AutoSize = true;
            this.lblPassword_accedi.Location = new System.Drawing.Point(56, 206);
            this.lblPassword_accedi.Name = "lblPassword_accedi";
            this.lblPassword_accedi.Size = new System.Drawing.Size(56, 13);
            this.lblPassword_accedi.TabIndex = 10;
            this.lblPassword_accedi.Text = "Password:";
            // 
            // lblUsername_accedi
            // 
            this.lblUsername_accedi.AutoSize = true;
            this.lblUsername_accedi.Location = new System.Drawing.Point(56, 157);
            this.lblUsername_accedi.Name = "lblUsername_accedi";
            this.lblUsername_accedi.Size = new System.Drawing.Size(58, 13);
            this.lblUsername_accedi.TabIndex = 9;
            this.lblUsername_accedi.Text = "Username:";
            // 
            // lblAccedi
            // 
            this.lblAccedi.AutoSize = true;
            this.lblAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccedi.Location = new System.Drawing.Point(120, 91);
            this.lblAccedi.Name = "lblAccedi";
            this.lblAccedi.Size = new System.Drawing.Size(86, 29);
            this.lblAccedi.TabIndex = 8;
            this.lblAccedi.Text = "Accedi";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(102, 22);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(124, 38);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 7;
            this.picBoxLogo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(54, 254);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Non hai un account? Registrati";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mTxtPassword_accedi
            // 
            this.mTxtPassword_accedi.Location = new System.Drawing.Point(57, 223);
            this.mTxtPassword_accedi.Name = "mTxtPassword_accedi";
            this.mTxtPassword_accedi.PasswordChar = '*';
            this.mTxtPassword_accedi.Size = new System.Drawing.Size(149, 20);
            this.mTxtPassword_accedi.TabIndex = 15;
            // 
            // frmAccedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 393);
            this.Controls.Add(this.mTxtPassword_accedi);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.txtUsername_accedi);
            this.Controls.Add(this.lblPassword_accedi);
            this.Controls.Add(this.lblUsername_accedi);
            this.Controls.Add(this.lblAccedi);
            this.Controls.Add(this.picBoxLogo);
            this.Name = "frmAccedi";
            this.Text = "Accedi";
            this.Load += new System.EventHandler(this.frmAccedi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccedi;
        private System.Windows.Forms.TextBox txtUsername_accedi;
        private System.Windows.Forms.Label lblPassword_accedi;
        private System.Windows.Forms.Label lblUsername_accedi;
        private System.Windows.Forms.Label lblAccedi;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MaskedTextBox mTxtPassword_accedi;
    }
}