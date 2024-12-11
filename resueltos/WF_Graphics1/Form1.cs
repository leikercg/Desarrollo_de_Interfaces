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
            // Para trabajar con gráficos hay que realizar dos pasos:
            //   1) Crear un objeto de la clase Graphics
            Graphics graphics=CreateGraphics();
            //   2) Usar el objeto creado para dibujar
            // Dibujo una línea
            graphics.DrawLine(new Pen(Color.Orange, 5), 50, 25, 300, 25);
            //Dibujo un rectángulo
            graphics.DrawRectangle(new Pen(Color.Green, 7), 50, 50, 300, 100);
            //Dibujo una elipse
            graphics.DrawEllipse(new Pen(Color.Indigo, 4), 50, 200, 300, 100);
            // Dibujo un Pie
            graphics.DrawPie(new Pen(Color.Red, 7), 50, 350, 200, 200, 0, 120);
            Point punto1 = new Point(400, 350);
            Point punto2 = new Point(450, 450);
            Point punto3 = new Point(350, 450);
            Point[] puntos = {punto1,punto2,punto3};
            graphics.DrawPolygon(new Pen(Color.Green,5),puntos);
            
            //Dibujo el relleno de las figuras
            
            //Dibujo un rectángulo
            graphics.FillRectangle(new SolidBrush(Color.Green), 600, 50, 300, 100);
            //Dibujo una elipse
            graphics.FillEllipse(new SolidBrush(Color.Indigo), 600, 200, 300, 100);
            // Dibujo un Pie
            graphics.FillPie(new SolidBrush(Color.Red), 650, 350, 200, 200, 0, 320);
        }
    }
}
