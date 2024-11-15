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
                label2.Text = label2.Text + " " + nombre.Text;
            }
        }

     
    }
}   
