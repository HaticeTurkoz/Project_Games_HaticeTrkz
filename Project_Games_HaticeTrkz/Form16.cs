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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            frm17.Show();
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
        }

        private void CikarmakolayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            frm19.Show();
        }

        private void CikarmazorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            frm20.Show();
        }

        private void carpmakolayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form21 frm21  = new Form21();
            frm21.Show();
        }

        private void carpmazorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form22 frm22 = new Form22();
            frm22.Show();

        }

        private void bolmekolayToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form23 frm23 = new Form23();
            frm23.Show();
        }

        private void bolmezorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form24 frm24 = new Form24();
            frm24.Show();
        }

        private void tOPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
            frm16.Hide();
        }
    }
}
