using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_menu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.Green;
        }

        private void cianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.Cyan;

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.BlueViolet;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Black;
        }

        private void amarilloClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amarilloToolStripMenuItem_Click(sender, e);
        }

        private void pasarAMayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text= textBox.Text.ToUpper();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
              amarilloToolStripMenuItem_Click(sender, e);
        }
    }
}
