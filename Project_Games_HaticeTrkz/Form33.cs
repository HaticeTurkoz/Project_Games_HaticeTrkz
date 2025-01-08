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
    public partial class Form33 : Form
    {
        int result ;

        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
        }

        void Result()
        {
            result = 0;
            if (textBox1.Text == "red") result += 1;
            if (textBox2.Text == "blue") result += 1;
            if (textBox3.Text == "yellow") result += 1;
            if (textBox4.Text == "purple") result += 1;
            if (textBox5.Text == "green") result += 1;
            if (textBox6.Text == "pink") result += 1;
            if (textBox7.Text == "orange") result += 1;
            label2.Text = result.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
         
           
            label2.Visible = true;
            Result();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form30 frm30 = new Form30();
            frm30.Show();
            this.Hide();
            frm30.Hide();
        }
    }
}
