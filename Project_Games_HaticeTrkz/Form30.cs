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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void nUMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form32 frm32 = new Form32();
            frm32.Show();
        }

        private void bODYPARTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 frm29 = new Form29();
            frm29.Show();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void cOLORSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form33 frm33 = new Form33();
            frm33.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form25 frm25 = new Form25();
            frm25.Show();
            this.Hide();
            frm25.Hide();
        }
    }
}
