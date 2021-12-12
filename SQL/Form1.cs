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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrydniki etf = new Sotrydniki();
            etf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Brigade_Click(object sender, EventArgs e)
        {
            Brigade BG = new Brigade();
            BG.ShowDialog();
        }

        private void workshop_Click(object sender, EventArgs e)
        {
            Chex CH = new Chex();
            CH.ShowDialog();
        }

        private void region_Click(object sender, EventArgs e)
        {
            Region RG = new Region();
            RG.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Izdelia IZD = new Izdelia();
            IZD.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tip_Ispitania TP = new Tip_Ispitania();
            TP.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ispitania IS = new Ispitania();
            IS.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sborka_Izdelia SB = new Sborka_Izdelia();
            SB.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ispitatelinia_laboratoria ISP = new Ispitatelinia_laboratoria();
            ISP.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Oborydovanie OB = new Oborydovanie();
            OB.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Chikl_Raboti CR = new Chikl_Raboti();
            CR.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tip_Izdelia TPI = new Tip_Izdelia();
            TPI.ShowDialog();
        }
    }
}
