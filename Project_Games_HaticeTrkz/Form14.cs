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
    public partial class Form14 : Form
    {
        private SoundPlayer ses;

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\monkey.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\monkey.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {

            ses.Stop();//form kapatıldığında ses de duracak
            ses.Dispose();//form kapatıldığında SoundPlayer'ı serbest bırakacak
        }
    }
}
