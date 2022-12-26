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
    public partial class comboSearch : Form
    {
        public comboSearch()
        {
            InitializeComponent();
        }

        private void comboSearch_Load(object sender, EventArgs e)
        {   
          
            // TODO: This line of code loads data into the 'emloeesDataSet.emploeeTable' table. You can move, or remove it, as needed.
            this.emploeeTableTableAdapter.Fill(this.emloeesDataSet.emploeeTable);

        }

       /* private string search_Click(object sender, EventArgs e)
        {
           //string qwery "Select * from emploeeTable where eSurnane = '"+ comboBox1.SelectedItem.ToString()+"'";
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            SqlCommand comLine = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = comLine;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();


        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            //string qwery "Select * from emploeeTable where eSurnane = '"+ comboBox1.SelectedItem.ToString()+"'";
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            SqlCommand comLine = new SqlCommand("Select * from emploeeTable where eSurname = '" + comboBox1.SelectedItem.ToString() + "'",con);
            SqlDataAdapter datAd = new SqlDataAdapter(comLine);
            DataTable table = new DataTable();
            datAd.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
    }
}
