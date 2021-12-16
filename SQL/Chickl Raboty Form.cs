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
    public partial class Chickl_Raboty_Form : Form
    {
        public Chickl_Raboty_Form()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public Chickl_Raboty_Form(int _id)
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
                ("Select * from cycle_workd where id_cycle_work=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
            ("Server=127.0.0.1;Database=soul;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from cycle_workd", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }


            private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
("Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                 ("INSERT INTO cycle_workd (id_region, assembly_of_assembly_components ) " +
                " values ('" + numericUpDown1.Text + "', '" + numericUpDown2.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
(@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" Delete From cycle_workd
                    Where id_cycle_work={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           (@"Server=127.0.0.1;Database=soul;charset=utf8;Uid=Tost;Pwd=123;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@" update cycle_workd set 
                    id_region='{numericUpDown1.Text}',
                    assembly_of_assembly_components='{numericUpDown2.Text}'
                    Where id_cycle_work='{id}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
