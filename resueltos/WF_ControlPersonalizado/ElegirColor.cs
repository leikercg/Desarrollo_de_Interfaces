using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ControlPersonalizado
{
    public partial class ElegirColor : UserControl
    {
        // Creo el atributo colorSeleccionado
        private Color colorSeleccionado;
        // Creo la propiedad y sus métodos de L y E
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

        private void Actualizar()
        {
            // Actualizo el color de la etiqueta
            ColorSeleccionado=Color.FromArgb(hScrollBar1.Value,hScrollBar2.Value,hScrollBar3.Value);    
            lblColor.BackColor= ColorSeleccionado;
            label4.Text = hScrollBar1.Value.ToString();
            label5.Text = hScrollBar2.Value.ToString();
            label6.Text = hScrollBar3.Value.ToString();

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }
    }
}
