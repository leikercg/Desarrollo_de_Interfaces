using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Para trabajar hay qure realizar dos pasos.
            // 1) Crear un obejro graphics para dibujar sobre el.
            Graphics grafico = CreateGraphics();
            // 2) usar el objeto creado para dibujar
            grafico.DrawLine(new Pen(Color.Orange, 5),50, 25,300,25);
            grafico.DrawRectangle(new Pen(Color.Green, 5), 50, 50, 300, 100);
        }
    }
}
