using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardo los datos en un archivo de texto
            GuardarDatos();
            // Guardo los datos introducidos en el DataGrid
            dataGridView1.Rows.Add(tbNombre.Text,tbApellidos.Text,tbTelefono.Text);
            // Borro los cuadros de texto
            tbNombre.Clear();tbApellidos.Clear();tbTelefono.Clear();

        }
        private void GuardarDatos()
        {
            // Creo un objeto de la clase StreamWriter para guardar los registros
            // le paso al constructor dos parámetros, primero el nombre del archivo
            // y el segundo parámetro toma el valor true para añadir registros
            StreamWriter archivo = new StreamWriter("alumno.txt",true);
            // Guardo en el archivo el contenido de los cuadros de texto
            // Cada uno se guardará en una línea
            archivo.WriteLine(tbNombre.Text);
            archivo.WriteLine(tbApellidos.Text);
            archivo.WriteLine(tbTelefono.Text);
            archivo.Close();
            archivo.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Si no existe el archivo de texto, lo creo, y si existe
            // muestro en el DataGrid los registros
            if (!File.Exists("alumno.txt"))
            {
                StreamWriter archivo = new StreamWriter("alumno.txt");
                archivo.Close();
                archivo.Dispose();
            }
            else // Relleno el DataGrid con los datos del archivo de texto alumno.txt
            {
                StreamReader archivo = new StreamReader("alumno.txt");
                // Recorro el archivo de principio a fin
                while(!archivo.EndOfStream)
                {
                    string nombre=archivo.ReadLine();
                    string apellidos= archivo.ReadLine();
                    string telefono= archivo.ReadLine();
                    dataGridView1.Rows.Add(nombre, apellidos, telefono);
                }
                archivo.Close();
                archivo.Dispose ();
            }
            }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Introduzco el nombre a eliminar en el cuadro de texto nombre
            // Busco el nombre introducido anteriormente en el DataGrid
            // para eso lo recorro de principio a fin, también podría recorrerlo
            // hasta que lo encuentre o hasta el final del archivo
            for (int f=0;f<dataGridView1.Rows.Count;f++)
            {
                // Si lo encuentro en el DataGrid
                if (tbNombre.Text == dataGridView1.Rows[f].Cells[0].Value.ToString())
                {
                    // Lo elimino del DataGrid con el método RemoveAt(num. fila)
                    dataGridView1.Rows.RemoveAt(f);
                    // Supongo que el nombre del alumno es único, por tanto,
                    // si lo encuentro, llamo al método BorrarRegistro para
                    // eliminar el registro del archivo de texto
                    ActualizarArchivo();
                    MessageBox.Show("Se ha borrado el registro");
                }
            }
        }
        private void ActualizarArchivo()
        {
            // Creo un objeto de la clase StreamWriter, le paso como parámetro 
            // al constructor el nombre del archivo, como existe, borra todos los datos
            StreamWriter archivo = new StreamWriter("alumno.txt");
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                // Elimino las tres líneas del archivo de texto relacionadas con el alumno
                archivo.WriteLine(dataGridView1.Rows[f].Cells[0].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[1].Value.ToString());
                archivo.WriteLine(dataGridView1.Rows[f].Cells[2].Value.ToString());
            }
            archivo.Close();
            archivo.Dispose();
        }
    }
}
