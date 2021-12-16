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
    public partial class BrigadeForm : Form
    {
        public BrigadeForm()
        {
            InitializeComponent();
            LoadCombobox();
        }
        public BrigadeForm(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            LoadString();
            id = _id;
        }
        int id;
        private void LoadString()
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from brigade where id_brigade=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from brigade", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // worker
            MySqlConnection con1 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * from brigade ", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "brigadier";
            comboBox1.ValueMember = "brigadier";

            //FCS
            MySqlConnection con2 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da2 = new MySqlDataAdapter
                ("Select * from brigade", con2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox4.DataSource = dt2;
            comboBox4.DisplayMember = "id_staff";
            comboBox4.ValueMember = "id_staff";

            //education

            MySqlConnection con3 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da3 = new MySqlDataAdapter
                ("Select * from brigade", con3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox5.DataSource = dt3;
            comboBox5.DisplayMember = "Chief";
            comboBox5.ValueMember = "Chief";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO brigade (brigadier, number_of_teams, number_of_employees, id_staff, Chief ) " +
                " VALUES ('" + comboBox1.Text + "', '" + comboBox2.Value.ToString().Replace(",", ".") + "', " +
                "'" + comboBox3.Value.ToString().Replace(",", ".") + "', '" + comboBox4.SelectedValue + "', " +
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
                ($@" update brigade set 
                    brigadier='{comboBox1.Text}',
                    number_of_teams='{comboBox2.Value.ToString().Replace(",", ".")}',
                    number_of_employees='{comboBox3.Value.ToString().Replace(",", ".")}',
                    id_staff='{comboBox4.SelectedValue}',
                    Chief='{comboBox5.Text}'
                    Where id_brigade={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete From brigade 
                    Where id_brigade={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
