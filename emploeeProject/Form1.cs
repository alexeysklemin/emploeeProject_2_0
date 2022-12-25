using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace emploeeProject
{
    public partial class loginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        //Data Source=laptop-alex\sqlexpress;Initial Catalog=emloees;Integrated Security=True
        public loginForm()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True";
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM loginTable";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (usrBox.Text.Equals(dr["account"].ToString()) && pswBox.Text.Equals(dr["passsword"].ToString()))
                {
                    Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are mistaken", "Repeat one more time", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            con.CreateCommand(); Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
