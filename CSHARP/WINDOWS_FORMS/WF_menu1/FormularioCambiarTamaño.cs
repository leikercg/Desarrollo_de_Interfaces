using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_menu1
{
    public partial class FormularioCambiarTamaño : Form
    {
        // Declaro los dos atributos
        private int ancho;
        private int alto;

        // Creo la prpiedad ancho
        public int Ancho
        {
            get
            {
                return int.Parse(textBoxAncho.Text);
            }
            set
            {
                textBoxAncho.Text= value.ToString();
            }
        }

        // Creo la prpiedad alto
        public int Alto
        {
            get
            {
                return int.Parse(textBoxAlto.Text);
            }
            set
            {
                textBoxAlto.Text = value.ToString();
            }
        }

        public FormularioCambiarTamaño()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Indicamos que devuelve, al cerrarlo
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.OK; //Indicamos que devuelve, al cerrarlo
            Close();

        }

   
    }
}
