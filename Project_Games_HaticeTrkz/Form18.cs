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
    public partial class Form18 : Form
    {
        int result = 0;
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "36")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "38")
            {
                result += 20;
            }

            else result += 0; if (textBox3.Text == "54")
            {
                result += 20;
            }

            else result += 0; if (textBox4.Text == "67")
            {
                result += 20;
            }
            else result += 0; if (textBox5.Text == "113")
            {
                result += 20;
            }
            else result += 0;

            if (result <= 100)
                label1.Text = result.ToString();
            else label1.Text = "100";
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            frm17.Show();
            this.Hide();
            Form16 form16 = new Form16();
            form16.Hide();
        }
    }
}
