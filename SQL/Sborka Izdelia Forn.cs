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
    public partial class Sborka_Izdelia_Forn : Form
    {
        public Sborka_Izdelia_Forn()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public Sborka_Izdelia_Forn(int _id)
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
                ("Select * from product_assembly where id_product_assembly=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from product_assembly", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO product_assembly (id_goods, availability_of_all_components, finished_products, id_brigade ) " +
                " values ('" + numericUpDown1.Text + "', '" + numericUpDown2.Text + "', " +
                "'" + comboBox1.Text + "', '" + numericUpDown3.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update product_assembly set 
                    id_goods='{numericUpDown1.Text}',
                    availability_of_all_components='{numericUpDown2.Text}',
                    finished_products='{comboBox1.Text}',
                    id_brigade='{numericUpDown3.Text}'
                    Where id_product_assembly='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From product_assembly 
                    Where id_product_assembly={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
