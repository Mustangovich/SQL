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
    public partial class Ispitatelinia_laboratoria : Form
    {
        public Ispitatelinia_laboratoria()
        {
            InitializeComponent();
            LoadTable();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from testing_laboratory", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        string query = "SELECT id_testing_laboratory AS Испытательная_Лаборатория, " +
            "id_goods AS Изделия, id_staff AS сотрудник, id_region AS Участок " +
            "from testing_laboratory";

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
                string query = @"SELECT id_testing_laboratory AS Испытательная_Лаборатория, " +
            "id_goods AS Изделия, id_staff AS сотрудник, id_region AS Участок " +
            "from testing_laboratory WHERE id_testing_laboratory IN (" + checkBox + ")";
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand); ;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ispitatelinia_laboratoria_Form ILF = new Ispitatelinia_laboratoria_Form();
            ILF.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                Ispitatelinia_laboratoria_Form ILF = new Ispitatelinia_laboratoria_Form(id);
                ILF.ShowDialog();
                LoadTable();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
            }
        }
    }
}
