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
            // Cierra la ventana, tiene shortcutkeys.
            this.Close();
        }

        private void amarilloClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color de fondo usando un elemento de la toolStrip
            tbTexto.BackColor=Color.LightYellow;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color del texto.
            tbTexto.ForeColor=Color.Red;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color de fondo.
            tbTexto.BackColor=Color.Cyan;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color del texto a negro.
            tbTexto.ForeColor = Color.Black;
        }

        private void amarilloClaroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Llama al evento que cambia el color.
            amarilloClaroToolStripMenuItem_Click(sender, e);
        }

        private void cyanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Llama al evento que cambia el color.
            cyanToolStripMenuItem_Click(sender, e);
        }

        private void mayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el texto a letras mayúsculas.
            tbTexto.Text=tbTexto.Text.ToUpper();
        }

        private void minusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el texto a letras minusculas.
            tbTexto.Text = tbTexto.Text.ToLower();
        }

        private void primeraLetraMayusculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Función que cambia la primera letra a mayuscula.

            // Si la longitud es mayor de 0
            if (tbTexto.Text.Length > 0)
            {
                // Pasa todas las letras a minúsculas.
                tbTexto.Text=tbTexto.Text.ToLower();

                // Coge la primera letra y la hace mayúscula, se concatena con el resto de texto hata longitud menos 1
                // indica el indice y la longitud, si no se indica nada es hasta el final.
                tbTexto.Text=tbTexto.Text.Substring(0,1).ToUpper()+tbTexto.Text.Substring(1);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Al pulsar el elemento de toolstrip llama al evento que cambia el color de fondo.
            // Es un boton y tiene una propiedad imagen.
            amarilloClaroToolStripMenuItem_Click(sender, e);
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // al escribir (levantar la tecla, se coge ese tamaño para el texto)
            // Se define el tamaño del texto, conviertiendo el string a int.
            tbTexto.Font=new Font(tbTexto.Font.FontFamily,int.Parse(toolStripTextBox1.Text));
        }

       /* NO HA FUNCIONADO, NO SE USA
        * private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            toolStripStatusLabel2.Text="("+e.X+","+e.Y+")";
        }*/

        private void tbTexto_MouseMove(object sender, MouseEventArgs e)
        {
            // Recoge el evento de mover el rato, y lo muestra en la toolStripStatus
            toolStripStatusLabel2.Text = "(" + e.X + "," + e.Y + ")";
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

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // al pulsar en el item se mostrará una ventana de dialogo creada.
            // se establece ok y se coge el valor del tipo de fuente.

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.Font = fontDialog1.Font;
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

        private void textoDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Voy a crear una instancia del formulario FormAyudaTexto
            FormAyudaTexto formAyudaTexto = new FormAyudaTexto();
            // Llamo al formulario que he instanciado
            //formAyudaTexto.Show();
            formAyudaTexto.ShowDialog();
        }

        private void cambiarTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creo una instacia de la clase FormularioCambiarTamaño
            FormCambiarTamaño formCambiarTamaño = new FormCambiarTamaño();
            // Llamo al formulario que he instanciado
            formCambiarTamaño.ShowDialog();
            // Compruebo si se ha pulsado el botón Aceptar o el Cancelar
            if(formCambiarTamaño.DialogResult == DialogResult.OK)
            {
                this.Width=formCambiarTamaño.Ancho;
                this.Height=formCambiarTamaño.Alto;
            }
        }

        private void seleccionarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cambia el color de fondo selecionandolo desde una ventana de seleccion
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.BackColor = colorDialog1.Color;
            }
        }
    }
}
