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
using System.IO; // Trabajar con ficheros

namespace WF_menu1
{
    public partial class ass : Form
    {
        public ass()
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Coordenadas: {e.X} :{ e.Y} ";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\DESARROLLO_DE_INTERFACES";
            saveFileDialog1.Filter="txt files (*.txt) | *.txt | All files (*.)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(textBox.Text);
                writer.Close();
                MessageBox.Show("Archivo guardado");
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\DESARROLLO_DE_INTERFACES";
            openFileDialog1.Filter = "txt files (*.txt) | *.txt | All files (*.)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog1.Font;
            }
        }

       
        private void cambiarColorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = colorDialog1.Color;
            }

        }

        private void cambiarColorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog1.Color;
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyudaTexto formAyudaTexto = new FormAyudaTexto(); // instanciamos una ventana
            formAyudaTexto.ShowDialog(); // La mostramos
            //formAyudaTexto.Show(); // La mostramos infinitamente  

        }

        private void cambiarTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCambiarTamaño formularioCambiarTamaño = new FormularioCambiarTamaño();
            formularioCambiarTamaño.ShowDialog();

            // Compruebo si se ha pulsado el boton aceptar o el boton cancelar

           if(formularioCambiarTamaño.DialogResult == DialogResult.OK)
            {
                this.Width = formularioCambiarTamaño.Ancho;
                this.Height = formularioCambiarTamaño.Alto;

            }

        }
    }
}
