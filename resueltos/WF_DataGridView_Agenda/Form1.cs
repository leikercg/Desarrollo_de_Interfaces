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

namespace WF_DataGridView_Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardo los datos en un archivo de texto
            GuardarDatosEnArchivo();
            // Guardo los datos introducidos a través de los TextBox en el DataGrid
            dataGridView1.Rows.Add(tbNombre.Text,tbApellido.Text,tbTelefono.Text);
            // Borro el contenido de los cuadros de texto
            tbNombre.Clear();tbApellido.Clear();tbTelefono.Clear();
        }
        private void GuardarDatosEnArchivo() 
        { 
            /*Creo un objeto de la clase StreamWriter para guardar los datos 
             de los usuarios, cada dato se guarda en una línea
            Le paso como parámetro al constructor de la clase StreamWriter
            el nombre del archivo y true para indicar que voy a añadir registros*/
            StreamWriter archivo = new StreamWriter("usuario.txt",true);
            /* Guardo en el archivo el contenido de los cuadros de texto,
             cada uno se guarda en una línea*/
            archivo.WriteLine(tbNombre.Text);
            archivo.WriteLine(tbApellido.Text);
            archivo.WriteLine(tbTelefono.Text);
            archivo.Close();
            archivo.Dispose();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Al cargar el formulario pregunto si no existe el archivo, en ese caso,
             lo creo*/
            if (!File.Exists("usuario.txt"))
            {
                StreamWriter archivo = new StreamWriter("usuario.txt");
                archivo.Close();
                archivo.Dispose();
            }
            else/* Si existe el archivo, lo leo y voy rellenando el DataGrid*/
            {
                StreamReader archivo = new StreamReader("usuario.txt");
                // Recorro el archivo de principio a fin
                while (!archivo.EndOfStream)
                {
                    string nombre = archivo.ReadLine();
                    string apellido = archivo.ReadLine();
                    string telefono = archivo.ReadLine();
                    dataGridView1.Rows.Add(nombre, apellido, telefono);
                }
                archivo.Close();
                archivo.Dispose();
            }      
        }
    }
}
