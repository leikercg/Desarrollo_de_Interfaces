using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Fooooooooooormulario";
            btn_Cerrar.Text = "Formulario cerrado";
        }

        private void click_cerrar(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario con this, no referimos al form
        }

        private void entrar_btn(object sender, EventArgs e)
        {
            btn_Cerrar.BackColor = Color.DarkRed;
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                label2.Text = "Introduce un nombre";
                label2.ForeColor = Color.Red;  // Cambiar el color del texto a rojo
            }
            else
            {
                label2.Text = "";
                label2.Text = label2.Text + " " + nombre.Text;
            }
        }

        private void buttonMostratMatricula_Click(object sender, EventArgs e)
        {
            label2.Text =$"El nombre de la alumna/o: {nombre.Text} está matriculado en: ";

            if (radioButtonPrimero.Checked)
            {
                label2.Text = $"El nombre de la alumna/o: {nombre.Text} está matriculado en: {radioButtonPrimero.Text}";

            }
            else if(radioButtonSegundo.Checked)
            {
                label2.Text= $"El nombre de la alumna/o: {nombre.Text} está matriculado en: {radioButtonSegundo.Text}";

            }

            if ((checkBoxDam.Checked && checkBoxDaw.Checked) && radioButtonPrimero.Checked)
            {

                MessageBox.Show("No sepuede matricular en ambos en primero");

            }
            else
            {
                if (checkBoxDam.Checked && checkBoxDaw.Checked)
                {
                    label2.Text += "DAM y DAW";
                }
                 else if (checkBoxDam.Checked)
                {
                    label2.Text += $", {checkBoxDam.Text}";

                }
                else if (checkBoxDaw.Checked)
                {
                    label2.Text += $", {checkBoxDaw.Text}";
                }
            }
        }

        private void checkBoxAceptarCondiciones_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAceptarCondiciones.Checked)
            {
                buttonMostratMatricula.Enabled = true;
         
            }
            else
            {
                buttonMostratMatricula.Enabled = false;

            }
        }

        private void radioButtonColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonColor.Checked)
            {
                this.BackColor = System.Drawing.Color.Aqua;
            }
            else
            {
                this.BackColor = System.Drawing.Color.RosyBrown;
            }

        }

        private void radioButtonTamaño_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTamaño.Checked)
            {
                this.ClientSize = new System.Drawing.Size(900, 1000);
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(800, 450);

            }
        }


    }
}   
