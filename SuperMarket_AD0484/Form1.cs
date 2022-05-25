using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_AD0484
{
    public partial class frmLegumes : Form
    {
        public frmLegumes()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order : " + listBox1.SelectedItem + "\n Quantity : " + comboBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
