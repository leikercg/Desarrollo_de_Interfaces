using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Menus1
{
    public partial class FormCambiarTamaño : Form
    {
        // Declaro los dos atributos
        private int ancho;
        private int alto;

        // Creo la propiedad Ancho
        public int Ancho
        {
            get
            {
                return int.Parse(tbAncho.Text);
            }
            set 
            { 
                tbAncho.Text=value.ToString();
            }
        }
        // Creo la propiedad Alto
        public int Alto
        {
            get
            {
                return int.Parse (tbAlto.Text);
            }
            set 
            { 
                tbAlto.Text=value.ToString();
            }

        }

        public FormCambiarTamaño()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
