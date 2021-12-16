using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL
{
    public partial class Tip_Ispitania : Form
    {
        public Tip_Ispitania()
        {
            InitializeComponent();
            LoadTable();
        }

        string quert = "SELECT id_type_of_test AS Тип_Испытания, id_trials AS Испытание, test_number AS Номер_Испытание, " +
            "id_workshop AS Цех " +
            "from type_of_test ";

        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
    ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (quert, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tip_Ispitania_Form TIF = new Tip_Ispitania_Form();
            TIF.ShowDialog();
            LoadTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkBox = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkBox == "")
                {
                    checkBox = "'" + checkedListBox1.CheckedItems[i].ToString() + "'";

                }
                else
                {

                    checkBox += ", " + "'" + checkedListBox1.CheckedItems[i].ToString() + "'";
                }

                MySqlConnection sqlConnection = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
                string query = @"SELECT id_type_of_test AS Тип_Испытания, id_trials AS Испытание, test_number AS Номер_Испытание, " +
            "id_workshop AS Цех " +
            "from type_of_test WHERE test_number IN (" + checkBox + ")";
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand); ;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                Tip_Ispitania_Form TIF = new Tip_Ispitania_Form(id);
                TIF.ShowDialog();
                LoadTable();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string checkBox = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkBox == "")
                {
                    checkBox = "'" + checkedListBox1.CheckedItems[i].ToString() + "'";

                }
                else
                {

                    checkBox += ", " + "'" + checkedListBox1.CheckedItems[i].ToString() + "'";
                }

                MySqlConnection sqlConnection = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
                string query = @"SELECT id_type_of_test AS Тип_Испытания, id_trials AS Испытание, test_number AS Номер_Испытание, " +
            "id_workshop AS Цех " +
            "from type_of_test WHERE test_number IN (" + checkBox + ")";
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand); ;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
        }
    }
}
