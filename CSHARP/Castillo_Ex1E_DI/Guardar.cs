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
    public partial class Guardar : Form
    {
        // Una variable para ver que hacer
        private bool guardar = true;

        // Creo la prpiedad guardar
        public bool GuardarBool
        {
            get
            {
                return guardar;
            }
            set
            {
                guardar = false;
            }
        }
        public Guardar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Si se pulsa guardar se establece a true
           guardar = true;
        }

        private void buttonNoGuardar_Click(object sender, EventArgs e)
        {            //Si se pulsa guardar se establece a false

            guardar = false;
        }
    }
}
