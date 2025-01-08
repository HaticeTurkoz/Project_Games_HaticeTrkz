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
    public partial class Form32 : Form
    {
        string control;
        int result = 0;

        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            groupBox5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            control = "buton1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control = "soru1dogru";//DOĞRU SEÇENEK


        }

        private void button3_Click(object sender, EventArgs e)
        {
            control = "buton3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label2.Visible = true;


            if (control == "soru1dogru") result += 20;
            else if (control == "buton1") result += 0;
            else if (control == "buton3") result += 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            control = "buton5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            control = "buton6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            control = "soru2dogru";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            if (control == "soru2dogru") result += 20;
            else if (control == "buton5") result += 0;
            else if (control == "buton6") result += 0;
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            control = "buton9";

        }
        private void button10_Click(object sender, EventArgs e)
        {
            control = "buton10";

        }
        private void button11_Click(object sender, EventArgs e)
        {
            control = "soru3dogru";

        }
        private void button12_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            if (control == "soru3dogru") result += 20;
            else if (control == "buton9") result += 0;
            else if (control == "buton10") result += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            control = "soru4dogru";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            control = "buton14";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            control = "buton15";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            if (control == "soru4dogru") result += 20;
            else if (control == "buton14") result += 0;
            else if (control == "buton15") result += 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            control = "buton17";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            control = "soru5dogru";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            control = "buton19";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (control == "soru5dogru") result += 20;
            else if (control == "buton19") result += 0;
            else if (control == "buton17") result += 0;
            label6.Visible = true;
            label6.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form30 frm30 = new Form30();
            frm30.Show();
            this.Hide();
      
            frm30.Hide();
        }
    }
}
