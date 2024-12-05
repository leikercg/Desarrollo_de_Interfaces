using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Controles2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text=monthCalendar1.SelectionRange.Start.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text="Año: " + dateTimePicker1.Value.Year.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text="Curso: " + comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label5.Text = "";
            comboBox1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text=label1.Text + "Ciclo: " + listBox1.Text;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            ListBox.SelectedObjectCollection ciudades = listBox2.SelectedItems;
            for(int i=0; i<ciudades.Count; i++)
            {
                label5.Text += " " + ciudades[i].ToString();
            }
        }
    }
}
