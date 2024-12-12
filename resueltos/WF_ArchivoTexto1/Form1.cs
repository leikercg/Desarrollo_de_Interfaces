using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF_ArchivoTexto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Abrimos flujo de escritura con el archivo .txt
            StreamWriter archivo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Compra.txt");

            // Recorremos los elementos del checkBox1
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Si está selecionado lo escribimos en el .txt
                if(checkedListBox1.GetItemChecked(i) == true)
                {
                    archivo.WriteLine(checkedListBox1.Items[i].ToString());
                }
                
            }
            // Cerramos el flujo de datos
            archivo.Close();
            archivo.Dispose();

            // Mostramos un mensaje de dialogo indicando que se ha realizado la compra.
            MessageBox.Show("Se ha guardado la compra");

            // mostrar las frutas compradas
            // Abrimos el flujo de lectura del archivo
            StreamReader archivo1 = new StreamReader(Directory.GetCurrentDirectory() + "\\compra.txt");
            while (!archivo1.EndOfStream)
            {
                // Añadimos cada linea como un checkBox2
                string line = archivo1.ReadLine();
                checkedListBox2.Items.Add(line);
            }

            // Cerramos el flujo de lectura.
            archivo1.Close();
            archivo1.Dispose(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Rellenar los checkbox con los elementos del texto al cargar el formulario.
            // Abrimos flujo de lectura del documento
            StreamReader archivo = new StreamReader(Directory.GetCurrentDirectory() + "\\Frutas.txt");
            while (!archivo.EndOfStream)
            {
                // Los cargamos en el checkbox1
                string line = archivo.ReadLine();
                checkedListBox1.Items.Add(line);
            }
            archivo.Close();
            archivo.Dispose();

        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
