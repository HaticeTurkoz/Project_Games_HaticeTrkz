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

    public partial class Form6 : Form
    {
        private SoundPlayer ses;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

             ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\bear.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\bear.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

            ses.Stop();//form5 kapatıldığında ses de duracak
            ses.Dispose();//form5 kapatıldığında SoundPlayer'ı serbest bırakacak
        }
    }
}
