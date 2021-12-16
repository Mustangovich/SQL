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
    public partial class Chex : Form
    {
        public Chex()
        {
            InitializeComponent();
            LoadTable();
        }

        string query = "SELECT id_workshop AS Цех, id_product_assembly AS Номер_Продукта, " +
            "id_equipment AS Оборудование, number_of_teams AS Количество_Сотрудников, " +
            "number_of_workshops_in AS Номер_Цеха, " +
            "id_brigade AS Бригада " +
            "from workshop";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                    ChexForm CF = new ChexForm(id);
                    CF.ShowDialog();
                    LoadTable();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (InvalidCastException)
                {
                    button1_Click(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChexForm CF = new ChexForm();
            CF.ShowDialog();
            LoadTable();
        }

        private void Chex_Load(object sender, EventArgs e)
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
                string query = "SELECT id_workshop AS Цех, id_product_assembly AS Номер_Продукта, " +
            "id_equipment AS Оборудование, number_of_teams AS Количество_Сотрудников, " +
            "number_of_workshops_in AS Номер_Цеха, " +
            "id_brigade AS Бригада " +
            "from workshop WHERE id_workshop IN (" + checkBox + ")";
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand); ;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
