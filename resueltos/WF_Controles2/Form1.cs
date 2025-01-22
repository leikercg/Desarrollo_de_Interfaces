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
            // Muestra la fecha seleccionada en el calendario
            label1.Text=monthCalendar1.SelectionRange.Start.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Limpia el texto que exista y muestra solo el año.
            label1.Text = "";
            label1.Text="Año: " + dateTimePicker1.Value.Year.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // coge el item seleccionado en el combo box y lo muestra en el label
            label1.Text="Curso: " + comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Limpia los label y los deja vacios
            label1.Text = "";
            label5.Text = "";

            //seleciona el primer elemtno por defecto.
            comboBox1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al ser pulsado un elemento de la lista lo muestra por la label
            label1.Text=label1.Text + "Ciclo: " + listBox1.Text;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            // Hay que tener habilitado el selectionMode
            label5.Text = "";

            // Creo una colleccion de elementos seleccionados llamado ciudades, con los elementos de la lista dos selccionados
            ListBox.SelectedObjectCollection ciudades = listBox2.SelectedItems;
            for(int i=0; i<ciudades.Count; i++)
            {
                label5.Text += " " + ciudades[i].ToString(); // Los mostramos en el label
            }
        }
    }
}
