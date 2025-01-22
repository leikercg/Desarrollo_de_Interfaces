﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            // usar sizemode para definir el tamaño de al imagen y la forma de adaptarse a su contenedor
            // hay que añador la imagen e recursos
            pictureBox2.Image=Properties.Resources.sun;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.azul;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se crea un objeto de clase directorio
            DirectoryInfo directorio = new DirectoryInfo("COLORES");
            // Se alberga la informacion de los directorio .png
            FileInfo[] archivos = directorio.GetFiles("*.png");
            for (int i = 0; i < archivos.Length; i++) {
                // cada nombre del archvio es agregado a la listbox
                listBox1.Items.Add(archivos[i].Name);
            }
            pictureBox4.ImageLocation = "data:image/jpeg;base64,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";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // El elemento seleccionado del listbBOx uno establece la ruta de la carpta colores.
            pictureBox3.Image = Image.FromFile("COLORES\\" + listBox1.SelectedItem.ToString());
        }
    }
}

