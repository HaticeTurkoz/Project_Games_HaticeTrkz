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
    public partial class Form22 : Form
    {
        int result = 0;
        public Form22()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 frm21 = new Form21();
            frm21.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "77")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "65")
            {
                result += 20;
            }

            else result += 0;

            if (textBox3.Text == "90")
            {
                result += 20;
            }

            else result += 0;

            if (textBox4.Text == "90")
            {
                result += 20;
            }
            else result += 0;

            if (textBox5.Text == "42")
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
