using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Controles1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Cambia el nombre del formulario
            this.Text = "Primeros controles en Windows Form";

            // Modifica el texto del boton cerrar.
            btnCerrar.Text = "Cerrar Formulario";
            // Modifica el ancho del boton btnCerrar
            btnCerrar.Width = 500;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la ventana del formulario.
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            // Al entrar al boton de cerrar cambia el color del fondo.
            btnCerrar.BackColor = Color.Cyan;

        }


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // comprobamos la contraseña
            string password = "12345";
            if (tbContraseña.Text == password) 
            {
                lbMensaje.Text = "Contraseña CORRECTA";
            }
            else{
                lbMensaje.Text = "INCORRECTA";
            }
            
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            // Al salir del botón, se cambia a color coral
            btnCerrar.BackColor= Color.LightCoral;
        }

        private void btnMostrarMatricula_Click(object sender, EventArgs e)
        {

            lbMatricula.Text = "La/El alumna/o: ";
            lbMatricula.Text = lbMatricula.Text + tbNombre.Text;
            lbMatricula.Text = lbMatricula.Text +" "+ tbApellido.Text;
            lbMatricula.Text = lbMatricula.Text + ", está matriculado en el curso: ";
            if (rbPrimero.Checked)
            {
                lbMatricula.Text = lbMatricula.Text + " " + rbPrimero.Text;
            }
            if (rbSegundo.Checked)
            {
                lbMatricula.Text = lbMatricula.Text + " " + rbSegundo.Text;
            }
            if (cboxDam.Checked)
            {
                lbMatricula.Text = lbMatricula.Text + " " + cboxDam.Text;
            }
            if (cboxDam.Checked)
            {
                lbMatricula.Text = lbMatricula.Text + " " + cboxDaw.Text;
            }
            if(rbPrimero.Checked & cboxDam.Checked & cboxDaw.Checked){
                MessageBox.Show("El alumno no se puede matricular en 1º DAM y DAW");   
            }
        }

        private void chboxAceptar_CheckedChanged(object sender, EventArgs e)
        {
            // Si el botón está selecionado se habilitan los botones
            if (chboxAceptar.Checked)
            {
                btnComprobar.Enabled = true;
            }
            else
            {
                btnComprobar.Enabled = false;
            }
        }

        private void rb800_CheckedChanged(object sender, EventArgs e)
        {
            // Cambia el tamaño
            //this.MaximumSize = new Size(800, 600);
            this.Width = 800;
            this.Height = 600;
        }

        private void rb1024_CheckedChanged(object sender, EventArgs e)
        {
            // Cambia el tamaño
            this.Width = 1024;
            this.Height = 768;
        }
    }
}
