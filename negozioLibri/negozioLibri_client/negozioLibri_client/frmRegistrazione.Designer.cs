
namespace negozioLibri_client
{
    partial class frmRegistrazione
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
            this.lblRegistrati = new System.Windows.Forms.Label();
            this.lblCodiceFiscale = new System.Windows.Forms.Label();
            this.txtCodiceFiscale = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.mTxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblRegistrati
            // 
            this.lblRegistrati.AutoSize = true;
            this.lblRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrati.Location = new System.Drawing.Point(104, 18);
            this.lblRegistrati.Name = "lblRegistrati";
            this.lblRegistrati.Size = new System.Drawing.Size(115, 29);
            this.lblRegistrati.TabIndex = 0;
            this.lblRegistrati.Text = "Registrati";
            // 
            // lblCodiceFiscale
            // 
            this.lblCodiceFiscale.AutoSize = true;
            this.lblCodiceFiscale.Location = new System.Drawing.Point(68, 182);
            this.lblCodiceFiscale.Name = "lblCodiceFiscale";
            this.lblCodiceFiscale.Size = new System.Drawing.Size(76, 13);
            this.lblCodiceFiscale.TabIndex = 1;
            this.lblCodiceFiscale.Text = "Codice fiscale:";
            // 
            // txtCodiceFiscale
            // 
            this.txtCodiceFiscale.Location = new System.Drawing.Point(144, 179);
            this.txtCodiceFiscale.Name = "txtCodiceFiscale";
            this.txtCodiceFiscale.Size = new System.Drawing.Size(100, 20);
            this.txtCodiceFiscale.TabIndex = 2;
            this.txtCodiceFiscale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodiceFiscale_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(68, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(68, 226);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 13);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "e-mail:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(68, 271);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(50, 13);
            this.lblCell.TabIndex = 6;
            this.lblCell.Text = "Cellulare:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(144, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(144, 223);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 9;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(144, 268);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(100, 20);
            this.txtCell.TabIndex = 10;
            this.txtCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCell_KeyPress);
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrati.FlatAppearance.BorderSize = 0;
            this.btnRegistrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrati.ForeColor = System.Drawing.Color.White;
            this.btnRegistrati.Location = new System.Drawing.Point(135, 324);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(49, 23);
            this.btnRegistrati.TabIndex = 14;
            this.btnRegistrati.Text = "OK";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // mTxtPassword
            // 
            this.mTxtPassword.Location = new System.Drawing.Point(144, 133);
            this.mTxtPassword.Name = "mTxtPassword";
            this.mTxtPassword.PasswordChar = '*';
            this.mTxtPassword.Size = new System.Drawing.Size(100, 20);
            this.mTxtPassword.TabIndex = 15;
            this.mTxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtPassword_KeyPress);
            // 
            // frmRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 394);
            this.Controls.Add(this.mTxtPassword);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCodiceFiscale);
            this.Controls.Add(this.lblCodiceFiscale);
            this.Controls.Add(this.lblRegistrati);
            this.Name = "frmRegistrazione";
            this.Text = "frmRegistrazione";
            this.Load += new System.EventHandler(this.frmRegistrazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrati;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.MaskedTextBox mTxtPassword;
    }
}