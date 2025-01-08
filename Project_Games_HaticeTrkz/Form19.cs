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
    public partial class Form19 : Form
    {
        int result = 0;
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "15")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "9")
            {
                result += 20;
            }

            else result += 0;
            
            if (textBox3.Text == "5")
            {
                result += 20;
            }

            else result += 0;
            
            if (textBox4.Text == "14")
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

        private void button2_Click(object sender, EventArgs e)
        {
        //    Form16 frm16 = new Form16();
        //    frm16.Show();
        //    this.Hide();
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
            frm16.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            frm20.Show();
            this.Hide();
        }
    }
}
