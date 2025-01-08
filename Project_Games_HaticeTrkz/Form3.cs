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
    public partial class Form3 : Form
    {
        private SoundPlayer ses;

        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();   
            frm7.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();   
            frm14.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1= new Form1();
            frm1.Show();
            this.Hide();
            frm1.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        SoundPlayer ses = new SoundPlayer();
        string dizin = Application.StartupPath + "\\animalsound.wav";//Tekrar dener misin sesi ya da dissapoşntment sesi
        ses.SoundLocation = dizin;
            ses.Play();
        }
    }
}
