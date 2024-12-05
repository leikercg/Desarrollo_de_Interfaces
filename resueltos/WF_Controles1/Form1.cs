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
            this.Text = "Primeros controles en Windows Form";

            btnCerrar.Text = "Cerrar Formulario";
            btnCerrar.Width = 200;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Cyan;

        }


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string password = "12345";
            if (tbContraseña.Text == password)
            {
                lbMensaje.Text = "Contraseña CORRECTA";
            }
            else{
                lbMensaje.Text = "Contraseña  NO CORRECTA";
            }
            
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
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
            //this.MaximumSize = new Size(800, 600);
            this.Width = 800;
            this.Height = 600;
        }

        private void rb1024_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 1024;
            this.Height = 768;
        }
    }
}
