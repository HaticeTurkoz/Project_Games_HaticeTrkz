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
    public partial class Form17 : Form
    {

        //int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
        int result = 0;
        public Form17()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sayi1 = Convert.ToInt32(textBox1.Text);
            //sayi2 = Convert.ToInt32(textBox2.Text);
            //sayi3 = Convert.ToInt32(textBox3.Text);
            //sayi5 = Convert.ToInt32(textBox5.Text);
            //sayi6 = Convert.ToInt32(textBox6.Text);


            if (textBox1.Text == "11")
            {
                result += 20;
            }
            else result += 0;


            if (textBox2.Text == "16")
            {
                result += 20;
            }

            else result += 0; 
            
            if (textBox3.Text == "19")
            {
                result += 20;
            }

            else result += 0;
            
            if (textBox5.Text == "20")
            {
                result += 20;
            }
            else result += 0; 
            
            if (textBox6.Text == "18")
            {
                result += 20;
            }
            else result += 0;

            if(result <=100)
            label1.Text = result.ToString();
            else label1.Text = "100";
            label1.Visible = true;
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
            frm16.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
            this.Hide();
        }
    }

}
