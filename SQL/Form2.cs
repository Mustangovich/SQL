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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;

        public Form2 (int _id)
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
                ("Select * from staff where id_staff=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

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
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "worker";
            comboBox2.ValueMember = "worker";

            //FCS
            MySqlConnection con2 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da2 = new MySqlDataAdapter
                ("Select * from staff", con2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "FCS";
            comboBox3.ValueMember = "FCS";

            //education

            MySqlConnection con5 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da5 = new MySqlDataAdapter
                ("Select * from staff", con5);
            DataTable dt5 = new DataTable();
            da.Fill(dt5);
            comboBox6.DataSource = dt5;
            comboBox6.DisplayMember = "education";
            comboBox6.ValueMember = "education";

            //category_employees

            MySqlConnection con6 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da6 = new MySqlDataAdapter
                ("Select * from staff", con6);
            DataTable dt6 = new DataTable();
            da.Fill(dt6);
            comboBox7.DataSource = dt6;
            comboBox7.DisplayMember = "category_employees";
            comboBox7.ValueMember = "category_employees";

            //Masters

            MySqlConnection con7 = new MySqlConnection
("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da7 = new MySqlDataAdapter
                ("Select * from staff", con7);
            DataTable dt7 = new DataTable();
            da.Fill(dt7);
            comboBox8.DataSource = dt;
            comboBox8.DisplayMember = "Masters";
            comboBox8.ValueMember = "Masters";


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO staff (worker, FCS, work_experience, discharge, education, category_employees, Masters ) " +
                " values ('" + comboBox2.Text + "', '" + comboBox3.Text + "', " +
                "'" + comboBox4.Value.ToString().Replace(",", ".")
                + "', '" + comboBox5.Value.ToString().Replace(",", ".") + "', " +
                "'" + comboBox6.Text + "','" + comboBox7.Text + "'," +
                "'" + comboBox8.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update staff set 
                    worker='{comboBox2.Text}',
                    FCS='{comboBox3.Text}',
                    work_experience='{comboBox4.Value.ToString().Replace(",", ".")}',
                    discharge='{comboBox5.Value.ToString().Replace(",", ".")}',
                    education='{comboBox6.Text}', 
                    category_employees='{comboBox7.Text}',
                    Masters='{comboBox8.Text}'
                    Where id_staff='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From staff 
                    Where id_staff={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void comboBox4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
