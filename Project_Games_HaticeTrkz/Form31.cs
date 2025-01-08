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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label6.Visible = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label7.Visible = true;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label8.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form26 frm26 = new Form26();
            frm26.Show();
            this.Hide();
            frm26.Hide();
        }
    }
}
