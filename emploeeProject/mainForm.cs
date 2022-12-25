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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emloeesDataSet.emploeeTable' table. You can move, or remove it, as needed.
            this.emploeeTableTableAdapter.Fill(this.emloeesDataSet.emploeeTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();
            SqlCommand com = new SqlCommand("insert into emploeeTable values (@id_emp, @eName, @eSurname, @eSecondName)", con);
            com.Parameters.AddWithValue("@id_emp", int.Parse(uIdBox.Text));
            com.Parameters.AddWithValue("@eName", uNameBox.Text);
            com.Parameters.AddWithValue("@eSurname", uSurnameBox.Text);
            com.Parameters.AddWithValue("@eSecondName", uSecNamBox.Text);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Succesfully saved");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();
            SqlCommand com = new SqlCommand("update emploeeTable set eName=@eName, eSurname=@eSurname, eSecondName=@eSecondName where id_emp=@id_emp", con);
            com.Parameters.AddWithValue("@id_emp", int.Parse(uIdBox.Text));
            com.Parameters.AddWithValue("@eName", uNameBox.Text);
            com.Parameters.AddWithValue("@eSurname", uSurnameBox.Text);
            com.Parameters.AddWithValue("@eSecondName", uSecNamBox.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully updates"); 
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();
            SqlCommand com = new SqlCommand("delete emploeeTable where id_emp=@id_emp", con);
            com.Parameters.AddWithValue("@id_emp", int.Parse(uIdBox.Text));
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully deleted");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();
            SqlCommand comLine = new SqlCommand("Select * from emploeeTable where id_emp=@id_emp", con);
            comLine.Parameters.AddWithValue("id_emp", int.Parse(uIdBox.Text));
            SqlDataAdapter datAd = new SqlDataAdapter(comLine);
            DataTable table = new DataTable();
            datAd.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
