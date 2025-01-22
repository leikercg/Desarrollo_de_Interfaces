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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_BD_Estudiantes
{
    public partial class Form1 : Form
    {
        // creo un string para guardar la información para
        // establecer la conexión con la BBDD
        string cadenaDeConexion = "Data Source=DESKTOP-MDAC0QE\\SQLEXPRESS;Initial Catalog=Estudiantes;User Id=sa;Password=alumno";
        // creo el objeto connection de la clase SqlConnection
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            /* instancio el objeto de la clase SqlConnection con el valor de 
             * la cadena de conexión
             */
            connection = new SqlConnection(cadenaDeConexion);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
             * abro la conexión entre la aplicación y el servidor de la BBDD
             */
            connection.Open();
            // creo la sql para guardar los datos introducidos en los TextBox
            //string sql = $"insert into alumno(matricula,nombre,ciclo) values ('{tbMatricula.Text}','{tbNombre.Text}','{tbCiclo.Text}')";
            string sql = $"insert into alumno(matricula,nombre,ciclo) values (@matricula,@nombre,@ciclo)";
            /*
             * creo un objeto de la clase SqlCommand para poder realizar la setencia sql 
             * sobre la BBDD con la que estoy trabajando
             */
            SqlCommand command = new SqlCommand(sql, connection);
            // relaciono los parámetros y los cuadros de texto
            command.Parameters.Add("@matricula",SqlDbType.Char, 10).Value=tbMatricula.Text;
            command.Parameters.Add("@nombre",SqlDbType.Char,10).Value=tbNombre.Text;
            command.Parameters.Add("@ciclo", SqlDbType.Char, 10).Value = tbCiclo.Text;
            // ejecuto el método ExecuteNonQuery para insertar el registro en la BBDD
            int numReg =command.ExecuteNonQuery();
            if (numReg == 0)
            {
                MessageBox.Show("No se ha podido guardar el registro");
            }else{
                MessageBox.Show("Se ha guardado el registro");
            }
            // borro el contenido de los cuadros de texto
            tbMatricula.Clear();tbNombre.Clear();tbCiclo.Clear();
            // cierro la conexión
            connection.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * abro la conexión entre la aplicación y el servidor de la BBDD
             */
            connection.Open();
            // creo la sql para recuperar los datos
            string sql = $"select nombre,ciclo from alumno where matricula ={tbMatricula.Text}";
            /*
             * creo un objeto de la clase SqlCommand para poder realizar la setencia sql 
             * sobre la BBDD con la que estoy trabajando
             */
            SqlCommand command = new SqlCommand(sql, connection);
            // Leo los registros que devuelve la sql
            SqlDataReader reader = command.ExecuteReader();
            // pregunto si se ha leído algún registro, en ese caso lo muestro en los TextBox
            if (reader.Read())
            {
                tbNombre.Text = (string)reader["nombre"];
                tbCiclo.Text = reader.GetString(1);
                MessageBox.Show($"Se ha consultado el alumno con nº de matrícula: {tbMatricula.Text}");
            }
            else {
                MessageBox.Show($"No existe el alumno con nº de matrícula{tbMatricula.Text}");
            }
            // cierro la conexión
            reader.Close();
            connection.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"delete from alumno where matricula='{tbMatricula.Text}'";
            SqlCommand command = new SqlCommand(sql, connection);
            int numReg = command.ExecuteNonQuery();
            if (numReg > 0)
            {

                MessageBox.Show($"Se ha borrado el alumno con nº de matrícula: {tbMatricula.Text}");

            }
            else
            {
                MessageBox.Show($"No existe el alumno: {tbMatricula.Text} en la BBDD");

            }
            tbMatricula.Clear(); tbNombre.Clear(); tbCiclo.Clear();
            connection.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"update alumno set nombre='{tbNombre.Text}', ciclo='{tbCiclo.Text}' where matricula='{tbMatricula.Text}'";
            SqlCommand command = new SqlCommand(sql, connection);
            int numReg = command.ExecuteNonQuery();
            if (numReg > 0)
            {
                MessageBox.Show("Se han modificado los datos");
            }
            else
            {
                MessageBox.Show($"No existe el alumno: {tbMatricula.Text} en la BBDD");
            }
            tbMatricula.Clear(); tbNombre.Clear(); tbCiclo.Clear();
            connection.Close();

        }

        private void btnMostrarRegEnDataGrid_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select matricula,nombre,ciclo from alumno";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            connection.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"select matricula,nombre,ciclo from alumno where ciclo = '{tbFiltro.Text}'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            connection.Close();

        }
    }
}
