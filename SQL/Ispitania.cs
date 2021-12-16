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
    public partial class Ispitania : Form
    {
        public Ispitania()
        {
            InitializeComponent();
            LoadTable();
        }

        string query = "SELECT id_trials AS Тест ,id_region AS Участок, test_number AS Номер_Теста, id_goods AS Изделие, " +
            "id_staff AS Сотрудник, id_type_of_test AS Тип_Теста " +
            "from trials";

        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (query, con);
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
            IspitanieForm IF = new IspitanieForm();
            IF.ShowDialog();
            LoadTable();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                    IspitanieForm IF = new IspitanieForm(id);
                    IF.ShowDialog();
                    LoadTable();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (InvalidCastException)
                {
                    button1_Click(null, null);
                }
            }
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
                string query = @"SELECT id_region AS Участок, test_number AS Номер_Теста, id_goods AS Изделие, " +
            "id_staff AS Сотрудник, id_type_of_test AS Тип_Теста " +
            "from trials WHERE test_number IN (" + checkBox + ")";
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
