using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF_Menus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra la ventana
            this.Close();
        }


        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // indica el directorio que se abrira por defecto
            saveFileDialog1.InitialDirectory = @"D:\";
            // indica el archivo se podrán seleccionar dentro del direcctorio
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // Indica cual será seleccionado por defecto, en este caso el dos.
            saveFileDialog1.FilterIndex = 2;
            // Recuerda el directorio establecido en caso de cierre.
            saveFileDialog1.RestoreDirectory = true;

            // Se abre un archivo, si se secciona una y se le da a guardar devuelve OK
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si se ha selecionado un archivo y guardar, abrimo un flujo de escritura
                StreamWriter archivo = new StreamWriter(saveFileDialog1.FileName);
                // Escribimos lo del contenido del text box
                archivo.Write(tbTexto.Text);
                // Cerramos el flujo
                archivo.Close();

                MessageBox.Show("Se ha guardado el archivo");
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                StreamReader archivo = new StreamReader(openFileDialog1.FileName);
                tbTexto.Text = archivo.ReadToEnd();
                archivo.Close();
            }
        }

        // Cambia el color de fondo mediante un menú contextual, hay que indicar que menu se le aplica
        private void cambiarColorDelTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.ForeColor = colorDialog1.Color;
            }
            
        }
        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color de fondo selecionandolo desde una ventana de seleccion
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.BackColor = colorDialog1.Color;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusHora.Text = "Hora: "+DateTime.Now.ToLongTimeString();
            toolStripStatusFecha.Text = "Fecha: " + DateTime.Now.Date.Day + "/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.Text = "";  
        }
    }
}
