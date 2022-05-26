using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SuperMarket_AD0484
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void GetAllCourses()
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; " +
                "Data Source =C:\\Users\\SCHOOL\\Desktop\\ibrahem AD0484\\SuperMarket_AD0484.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Courses", con);
            con.Open();
            adapter.Fill(dt);
            dwgCourses.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source=C:\\Users\\SCHOOL\\Desktop\\ibrahem AD0484\\SuperMarket_AD0484.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Courses values(@ID, @Name, @Number)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Number", int.Parse(txtNumber.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Complete");
            GetAllCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Courses Where ID=@ID";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source=C:\\Users\\SCHOOL\\Desktop\\ibrahem AD0484\\SuperMarket_AD0484.accdb");

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Complete");
            GetAllCourses();
        }

        private void dwgCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dwgCourses.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dwgCourses.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dwgCourses.CurrentRow.Cells[2].Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetAllCourses();
        }
    }
}
