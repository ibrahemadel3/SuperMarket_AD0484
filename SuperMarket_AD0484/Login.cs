using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_AD0484
{
    public partial class frmlogin : Form
    {
        private string _user;
        public frmlogin(string user)
        {
            InitializeComponent();
            _user = user;
        }
        private void btnForm1_Click_1(object sender, EventArgs e)
        {
            frmLegumes frm1 = new frmLegumes();
            frm1.TopLevel = false;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            frmJuices frm2 = new frmJuices();
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.TopLevel = false;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
 
            
                lblwel.Text = "welcome " + _user;
            
        }
    }
}
