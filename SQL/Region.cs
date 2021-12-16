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
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
            LoadTable();
        }

        string query = "SELECT id_region AS Участок, number_of_plots AS Номер_Участка, product_quantity AS Количество_Продукта, " +
            "number_of_teams AS Номер_Команды, id_goods AS Изделие, id_brigade AS Бригада, " +
                "id_workshop AS Цех, id_staff AS Сотрудник, id_testing_laboratory AS Испытательная_Лаборатория " +
            "from region ";

        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (query , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Region_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Region_Form RF = new Region_Form();
            RF.ShowDialog();
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
                string query = @"SELECT id_region AS Участок, number_of_plots AS Номер_Участка, product_quantity AS Количество_Продукта, " +
            "number_of_teams AS Номер_Команды, id_goods AS Изделие, id_brigade AS Бригада, " +
                "id_workshop AS Цех, id_staff AS Сотрудник, id_testing_laboratory AS Испытательная_Лаборатория " +
            "from region WHERE id_region IN (" + checkBox + ")";
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
                Region_Form RF = new Region_Form(id);
                RF.ShowDialog();
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
