using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BBDD_Estudiantes
{
    public partial class Form1 : Form
    {
        // Creo un String para guardar la información de la conexion
        string cadenaDeConexion = "Data Source=DESKTOP-MDAC0QE\\SQLEXPRESS;Initial Catalog=Estudiantes;User Id=sa;Password=alumno";
        // creo el objeto connection de la clase sqlConnection
        SqlConnection connection;
        
        public Form1()
        {
            InitializeComponent();
            // Instancio el objeto de la clase SQLConnnection con el valor de la cadena de conexión
            connection = new SqlConnection(cadenaDeConexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Abro la conexión entre la aplicaión y la base de datos
            connection.Open();
            // Creo la sql para guardar los datos introducidos en los textos
            string sql = $"insert into alumno(matricula, nombre, ciclo) values('{textBoxMatricula.Text}','{textBoxNombre.Text}','{textBoxCiclo.Text}')";

            // Creo un objeto de la clase SQLcommand, para ejecutar la SQL
            SqlCommand command = new SqlCommand(sql, connection);

            // Ejecutamos con ExecuteNonQuery, siempre que se crea, actualiza, borra o inserta, no devuelve el numero entero de los afectados.
            int filasAfectadas = command.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                MessageBox.Show("No se ha podido ingresar el alumno");
            }
            else
            {
                MessageBox.Show("Filas afectadas" + filasAfectadas);
                textBoxCiclo.Clear();
                textBoxMatricula.Clear();
                textBoxNombre.Clear();

            }

            connection.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            // Abro la conexión entre la aplicaión y la base de datos
            connection.Open();
            // Creo la sql para selecionar los datos
            string sql = $"Select nombre, ciclo, matricula from alumno where matricula = '{textBoxMatricula.Text}'";

            // Creo un objeto de la clase SQLcommand, para ejecutar la SQL
            SqlCommand command = new SqlCommand(sql, connection);

            // Ejecutamos con ExecuteNonQuery, siempre que se crea, actualiza, borra o inserta, no devuelve el numero entero de los afectados.
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBoxCiclo.Text=reader.GetString(1);
                textBoxMatricula.Text = reader.GetString(2);
                textBoxNombre.Text = reader.GetString(0);
            }
            else
            {
                MessageBox.Show("Filas no encontradas");
               
            }
            reader.Close();
            connection.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
