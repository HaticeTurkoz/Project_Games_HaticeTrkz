using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project_Games_HaticeTrkz
{
    public partial class Form29 : Form
    {
        public string sec;
        private SoundPlayer ses;
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\dog.wav";
            ses.SoundLocation = dizin;
            ses.Play();

            //if (sec == "dog")
            //{
            //    button2.BackColor = Color.Green;

            //}
            //else if (sec == "cat") button1.BackColor = Color.Red;
            //else if (sec == "duck") button3.BackColor = Color.Red;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\bear.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\bird.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1.BackColor = Color.Red;
            //sec = "cat";
            button1.BackColor = Color.Red;
            button2.Visible = false;
            button3.Visible = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sec = "dog";
            button2.BackColor = Color.Green;
            button1.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            //sec = "duck";
            button1.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
            button4.Visible = false;
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button7.Visible = false;
            button9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Green;
            button8.Visible = false;
            button7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button5.Visible = true;
            button2.Visible = true;
            button9.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button8.Visible = false;
            button7.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
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
