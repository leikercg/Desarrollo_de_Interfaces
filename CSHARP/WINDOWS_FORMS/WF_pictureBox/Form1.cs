using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_pictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRojo_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.rojo;
        }

        private void buttonAzul_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.azul;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directorio = new DirectoryInfo("COLORES");
            FileInfo[] archivos = directorio.GetFiles("*.png");
            for (int i = 0; i < archivos.Length; i++)
            {
                listBox1.Items.Add(archivos[i].Name); // Añadir el nombre completo al listBox
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // EL elemento selecionado
        {
            pictureBox3.Image = Image.FromFile("colores\\"+listBox1.SelectedItem.ToString());

        }
    }
}
