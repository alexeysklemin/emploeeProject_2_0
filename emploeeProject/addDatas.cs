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
    public partial class addDatas : Form
    {
        public addDatas()
        {
            InitializeComponent();
        }

        internal static void ShowDialogs()
        {
            throw new NotImplementedException();
        }

        private void addDatas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emloeesDataSet3.result_table' table. You can move, or remove it, as needed.
            this.result_tableTableAdapter.Fill(this.emloeesDataSet3.result_table);
            // TODO: This line of code loads data into the 'emloeesDataSet2.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.emloeesDataSet2.departments);
            // TODO: This line of code loads data into the 'emloeesDataSet1.specializing' table. You can move, or remove it, as needed.
            this.specializingTableAdapter.Fill(this.emloeesDataSet1.specializing);
            // TODO: This line of code loads data into the 'emloeesDataSet.emploeeTable' table. You can move, or remove it, as needed.
            this.emploeeTableTableAdapter.Fill(this.emloeesDataSet.emploeeTable);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True");
            con.Open();

          /*  SqlCommand addCom = new SqlCommand

                addCom.Parameters.AddWithValue("@id_emp", int.Parse(uIdBox.Text));

            SqlDataAdapter datAd = new SqlDataAdapter(addCom);
            DataTable table = new DataTable();
            datAd.Fill(table);*/

        }
    }
}
