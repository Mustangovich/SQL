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
    public partial class Sotrydniki : Form
    {

        public Sotrydniki()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from staff", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // worker
            MySqlConnection con1 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * from staff", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "worker";
            comboBox1.ValueMember = "worker";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }

        void ComboBoxSelectedIndexChanged(object sender,EventArgs e)
        {
             
        }

        string query;
        const string _query = "SELECT staff.worker, staff.FCS, staff.work_experience, " +
            "staff.discharge, staff.education, staff.category_employees, staff.Masters " +
            "from staff ";


        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("SELECT staff.worker, staff.FCS, staff.work_experience, " +
            "staff.discharge, staff.education, staff.category_employees, staff.Masters " +
            "from staff", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            if (!Filter.Checked)
            {
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
            }
            panel1.Visible = Filter.Checked;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
