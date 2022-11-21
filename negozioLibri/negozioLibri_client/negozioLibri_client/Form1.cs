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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUtente_Click(object sender, EventArgs e)
        {
            frmAccedi frmAcc = new frmAccedi();
            frmAcc.ShowDialog();
        }

        private void btnCarrello_Click(object sender, EventArgs e)
        {

        }

        private void btnLente_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoHome_Click(object sender, EventArgs e)
        {
            frmHome_Load(sender, e);
        }
    }
}
