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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label9.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form26 frm26 = new Form26();
            frm26.Show();
            this.Hide();
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
            label8.Visible = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label10.Visible = true;

        }

        private void Form27_Load(object sender, EventArgs e)
        {
            label11.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //Form26 frm26 = new Form26();
            //frm26.Show();
            Form26 frm26 = new Form26();
            frm26.Show();
            this.Hide();
            frm26.Hide();

        }
    }
}
