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
    public partial class ChexForm : Form
    {
        public ChexForm()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public ChexForm(int _id)
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
                ("Select * from workshop where id_workshop=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from workshop", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void delButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
    ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO workshop (id_product_assembly, id_equipment, number_of_teams, number_of_workshops_in, id_brigade ) " +
                " VALUES ('" + comboBox1.Text + "', '" + comboBox2.Text + "', " +
                "'" + comboBox3.Text + "', '" + comboBox4.Text + "', " +
                "'" + comboBox5.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
             MySqlConnection con = new MySqlConnection
            (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update workshop set 
                    worker='{comboBox1.Text}',
                    FCS='{comboBox2.Text}',
                    work_experience='{comboBox3.Text}',
                    discharge='{comboBox4.Text}',
                    education='{comboBox5.Text}'
                    Where id_staff='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
