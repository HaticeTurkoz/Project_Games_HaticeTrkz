using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Games_HaticeTrkz
{
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            label1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form26 frm26 = new Form26();
            //frm26.Show();
            Form26 frm26 = new Form26();
            frm26.Show();
            this.Hide();
            frm26.Hide();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
        }
    }
}
