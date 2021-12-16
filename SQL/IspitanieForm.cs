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
    public partial class IspitanieForm : Form
    {
        public IspitanieForm()
        {
            InitializeComponent();
            LoadString();
        }

        public IspitanieForm(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            LoadString();
            id = _id;
        }

        int id;

        public void LoadString()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from trials where id_trials=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from trials", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO trials (id_trials, id_region, test_number, id_goods, id_staff, id_type_of_test ) " +
                " values ('" + comboBox1.Text + "', '" + numericUpDown1.Text + "', " +
                "'" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "', " +
                "'" + numericUpDown4.Text + "','" + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void IspitanieForm_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update trials set 
                    id_region='{comboBox1.Text}',
                    test_number='{numericUpDown1.Text}',
                    id_goods='{numericUpDown2.Text}',
                    id_staff='{numericUpDown3.Text}',
                    id_type_of_test='{numericUpDown4.Text}'
                    Where id_trials='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From trials 
                    Where id_trials={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
