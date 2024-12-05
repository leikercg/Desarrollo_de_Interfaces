using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlForm
{
    public partial class ElegirColor : UserControl
    {
        // Crep el atributo colorSelecionado
        private Color colorSeleccionado;
        // Creo la propiedad y sus metodos de L y E

        public Color ColorSeleccionado
        {
            get {return colorSeleccionado;}
            set {colorSeleccionado = value;}

        }


        public ElegirColor()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            Actualizar();
        }
         private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            // Actualizo el color
            ColorSeleccionado = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            lbColor.BackColor = ColorSeleccionado;
            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = hScrollBar2.Value.ToString();
            label3.Text = hScrollBar3.Value.ToString();

        }
    }
}
