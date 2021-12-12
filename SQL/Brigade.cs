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
    public partial class Brigade : Form
    {
        public Brigade()
        {
            InitializeComponent();
            LoadTable();
            LoadCombobox();
        }
        const string query = "SELECT brigade.brigadier, brigade.number_of_teams, brigade.number_of_employees, " +
    "brigade.id_staff, brigade.Chief " +
    "from brigade ";
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from staff", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
    ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrigadeForm BGF = new BrigadeForm();
            BGF.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                Form2 etf = new Form2(id);
                etf.ShowDialog();
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
