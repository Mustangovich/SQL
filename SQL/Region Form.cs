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
    public partial class Region_Form : Form
    {
        public Region_Form()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public Region_Form(int _id)
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
                ("Select * from region where id_region=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from region", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

            private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO region (number_of_plots, product_quantity, number_of_teams, id_goods, id_brigade, id_workshop, id_staff, id_testing_laboratory ) " +
                " values ('" + numericUpDown1.Text + "', '" + numericUpDown2.Text + "', " +
                "'" + numericUpDown3.Text + "', '" + numericUpDown4.Text + "', " +
                "'" + numericUpDown5.Text + "','" + numericUpDown6.Text + "'," + 
                "'" + numericUpDown7.Text + "','" + numericUpDown8.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update region set 
                    number_of_plots='{numericUpDown1.Text}',
                    product_quantity='{numericUpDown2.Text}',
                    number_of_teams='{numericUpDown3.Text}',
                    id_goods='{numericUpDown4.Text}',
                    id_brigade='{numericUpDown5.Text}', 
                    id_workshop='{numericUpDown6.Text}',
                    id_staff='{numericUpDown7.Text}',
                    id_testing_laboratory='{numericUpDown8.Text}'
                    Where id_region='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From region 
                    Where id_region={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
