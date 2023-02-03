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

            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();
            string v = comboBox1.SelectedItem.ToString();
            Console.WriteLine(v);

            SqlCommand comLine = new SqlCommand("Select * from emploeeTable where eSurname = @eSurname", con);
            comLine.Parameters.AddWithValue("eSurname", v);
            /* comLine.Parameters.AddWithValue("eSurname", v));
             SqlDataAdapter datAd = new SqlDataAdapter(comLine);
             DataTable table = new DataTable();
             datAd.Fill(table);
             dataGridView1.DataSource = table; SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
             SqlCommand comLine = new SqlCommand("Select * from emploeeTable WHERE  = '" + comboBox1.SelectedItem.ToString() + "'",con);
           //  
             //string v = "Smith";
           //  SqlCommand comLine = new SqlCommand("Select * from emploeeTable WHERE eSurname = '" + v+"'", con);*/
            SqlDataAdapter datAd = new SqlDataAdapter(comLine);
            DataTable table = new DataTable();
            datAd.Fill(table);
            comLine.ExecuteNonQuery();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void addDaatas_Click(object sender, EventArgs e)
        {
            Hide();
            addDatas addDatas = new addDatas();
            addDatas.ShowDialog();
        }
    }
}
