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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void nUMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form27 frm27 = new Form27();
            frm27.Show();

        }

        private void cOLORSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 frm28 = new Form28();
            frm28.Show();
        }

        private void bODYPARTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 frm31 = new Form31();
            frm31.Show();

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
