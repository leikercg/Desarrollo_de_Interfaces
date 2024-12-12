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
            this.Close();
        }

        private void amarilloClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.BackColor=Color.LightYellow;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.ForeColor=Color.Red;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.BackColor=Color.Cyan;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.ForeColor = Color.Black;
        }

        private void amarilloClaroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            amarilloClaroToolStripMenuItem_Click(sender, e);
        }

        private void cyanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cyanToolStripMenuItem_Click(sender, e);
        }

        private void mayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.Text=tbTexto.Text.ToUpper();
        }

        private void minusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTexto.Text = tbTexto.Text.ToLower();
        }

        private void primeraLetraMayusculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbTexto.Text.Length > 0)
            {
                tbTexto.Text=tbTexto.Text.ToLower();
                tbTexto.Text=tbTexto.Text.Substring(0,1).ToUpper()+tbTexto.Text.Substring(1,tbTexto.Text.Length-1);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            amarilloClaroToolStripMenuItem_Click(sender, e);
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            tbTexto.Font=new Font(tbTexto.Font.FontFamily,int.Parse(toolStripTextBox1.Text));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel2.Text="("+e.X+","+e.Y+")";
        }

        private void tbTexto_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel2.Text = "(" + e.X + "," + e.Y + ")";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"d:\ARCHIVOS\DE_TEXTO";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter archivo = new StreamWriter(saveFileDialog1.FileName);
                archivo.Write(tbTexto.Text);
                archivo.Close();
                MessageBox.Show("Se ha guardado el archivo");
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"d:\ARCHIVOS\DE_TEXTO";
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
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.Font = fontDialog1.Font;
            }
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTexto.BackColor = colorDialog1.Color;
            }
        }

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
    }
}
