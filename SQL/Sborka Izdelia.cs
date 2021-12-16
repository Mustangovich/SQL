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
    public partial class Sborka_Izdelia : Form
    {
        public Sborka_Izdelia()
        {
            InitializeComponent();
            LoadTable();
        }

        string query = "SELECT id_product_assembly AS Сборка_Изделия, id_goods AS Изделие, " +
            "availability_of_all_components AS Наличие_Всех_Компонентов, finished_products AS Законченная_Продукция, " +
            "id_brigade AS бригада " +
            "from product_assembly ";

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
            Sborka_Izdelia_Forn SIF = new Sborka_Izdelia_Forn();
            SIF.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                Sborka_Izdelia_Forn SIF = new Sborka_Izdelia_Forn(id);
                SIF.ShowDialog();
                LoadTable();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
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
                string query = @"SELECT id_product_assembly AS Сборка_Изделия, id_goods AS Изделие, " +
            "availability_of_all_components AS Наличие_Всех_Компонентов, finished_products AS Законченная_Продукция, " +
            "id_brigade AS бригада " +
            "from product_assembly WHERE availability_of_all_components IN (" + checkBox + ")";
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
