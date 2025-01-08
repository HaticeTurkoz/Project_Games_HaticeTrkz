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
    public partial class Form15 : Form
    {
        private SoundPlayer ses;

        public string sec, picCont1, picCont2, picCont3;

        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sec = "kedi";
             ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kedi.wav";//burada kedinin sesini çal
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ses.Stop();
            sec = "fil";
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\fil.wav";//burada fil sesini çal
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ses.Stop();
            sec = "ayı";
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\bear.wav";//burada ayı sesini çal
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (sec == "fil")
            {
                pictureBox1.Visible = false;

                //picCont1 = "false";
                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\bird.wav";//burada Harika Doğru bildin desin
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            else if (sec == "kedi" || sec == "ayı")
            {
                pictureBox1.Visible = true;
                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\bird.wav";//Tekrar dener misin sesi ya da dissapoşntment sesi
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            if (pictureBox1.Visible == false) picCont1 = "false";
            CheckAllPicturesHidden();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (sec == "kedi")
            {
                pictureBox2.Visible = false;

                //picCont2 = "false";
                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\bird.wav";//burada Harika Doğru bildin desin
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            else if (sec == "fil" || sec == "ayı")
            {
                pictureBox2.Visible = true;
                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\bird.wav";//Tekrar dener misin sesi ya da dissapoşntment sesi
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            if (pictureBox2.Visible == false) picCont2 = "false";
            CheckAllPicturesHidden();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (sec == "ayı")
            {
                pictureBox3.Visible = false;

                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\bird.wav";//burada Harika Doğru bildin desin
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            else if (sec == "kedi" || sec == "fil")
            {
                pictureBox3.Visible = true;
                //SoundPlayer ses = new SoundPlayer();
                //string dizin = Application.StartupPath + "\\fil.wav";//Tekrar dener misin sesi ya da dissapoşntment sesi
                //ses.SoundLocation = dizin;
                //ses.Play();
            }
            if (pictureBox3.Visible == false) picCont3 = "false";
            CheckAllPicturesHidden();
        }
        public void CheckAllPicturesHidden()
        {
            if (picCont1 == "false" && picCont2 == "false" && picCont3 == "false")
            {
                // soundPlayer.Play(); // Tüm resimler gizlendiğinde oynatılacak ses
                 ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\dogru.wav";//Harika hepsini doğru yaptın sesi
                ses.SoundLocation = dizin;
                ses.Play();

            }
        }
    }
}
