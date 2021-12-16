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
    public partial class Ispitatelinia_laboratoria_Form : Form
    {
        public Ispitatelinia_laboratoria_Form()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public Ispitatelinia_laboratoria_Form(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            LoadString();
            id = _id;
        }

        private void LoadString()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from testing_laboratory where id_testing_laboratory=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
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

            private void Ispitatelinia_laboratoria_Form_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO testing_laboratory (id_goods, id_staff, id_region ) " +
                " values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', " +
                "'" + comboBox3.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update testing_laboratory set 
                    id_goods='{comboBox1.Text}',
                    FCS='{comboBox2.Text}',
                    work_experience='{comboBox3.Text}'
                    Where id_testing_laboratory='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From testing_laboratory 
                    Where id_testing_laboratory={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
