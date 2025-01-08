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
    public partial class Form23 : Form
    {
        int result = 0;

        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form16 frm16 = new Form16();
            //frm16.Show();
            //this.Hide();
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
            frm16.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form24 frm24 = new Form24();
            frm24.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "5")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "19")
            {
                result += 20;
            }

            else result += 0;

            if (textBox3.Text == "7")
            {
                result += 20;
            }

            else result += 0;

            if (textBox4.Text == "6")
            {
                result += 20;
            }
            else result += 0;

            if (textBox5.Text == "4")
            {
                result += 20;
            }
            else result += 0;

            if (result <= 100)
                label1.Text = result.ToString();
            else label1.Text = "100";
            label1.Visible = true;
        }
    }
}
