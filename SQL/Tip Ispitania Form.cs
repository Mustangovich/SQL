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
    public partial class Tip_Ispitania_Form : Form
    {
        public Tip_Ispitania_Form()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public Tip_Ispitania_Form(int _id)
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
                ("Select * from type_of_test where id_type_of_test=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from type_of_test", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO type_of_test (id_trials, test_number, id_workshop ) " +
                " values ('" + numericUpDown1.Text + "', '" + numericUpDown2.Text + "', " +
                "'" + numericUpDown3.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update type_of_test set 
                    id_trials='{numericUpDown1.Text}',
                    test_number='{numericUpDown2.Text}',
                    id_workshop='{numericUpDown3.Text}'
                    Where id_type_of_test='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From type_of_test 
                    Where id_type_of_test={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
