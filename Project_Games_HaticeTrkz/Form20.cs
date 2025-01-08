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
    public partial class Form20 : Form
    {
        int result = 0;
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "21")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "42")
            {
                result += 20;
            }

            else result += 0;

            if (textBox3.Text == "12")
            {
                result += 20;
            }

            else result += 0;

            if (textBox4.Text == "25")
            {
                result += 20;
            }
            else result += 0;


            if (textBox5.Text == "36")
            {
                result += 20;
            }
            else result += 0;

            if (result <= 100)
                label1.Text = result.ToString();
            else label1.Text = "100";
            label1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            frm19.Show();
            this.Hide();
        }
    }
}
