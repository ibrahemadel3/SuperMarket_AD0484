using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_AD0484
{
    
    public partial class frmSupermarket : Form
    {
       private List<user> UsersList = new List<user>(); 
        public frmSupermarket()
        {
            user user1 = new user("ghazzwe", "0484");
            InitializeComponent();
            UsersList.Add(user1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            foreach (user user in UsersList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    frmlogin frm = new frmlogin(txtUserName.Text);
                    frm.Show();
                    return;
                }
            }
        }
    }
}
