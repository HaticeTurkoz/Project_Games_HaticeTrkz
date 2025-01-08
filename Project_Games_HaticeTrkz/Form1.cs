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
    public partial class Form1 : Form
    {
        private SoundPlayer ses;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form25 frm25 = new Form25();
            frm25.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form16 frm16 = new Form16();
            frm16.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\anasinifi.wav";//burada oynanacak oyunu seslendiren ses olacak
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            Form25 frm25 = new Form25();
            frm25.Show();
            //this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form16 frm16 = new Form16();
            frm16.Show();
        }
    }
}
