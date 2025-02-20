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

namespace Treapptment
{
    public partial class Dashboard : Form
    {
        string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        SqlConnection connection;
        public Dashboard()
        {
            InitializeComponent();
            CargarPacientes();
        }

        public void CargarPacientes() // Carga los pacientes en la datagrid
        {
            // Crear una nueva conexión a la base de datos
            connection = new SqlConnection(cadenaDeConexion);

            // Crear el comando para seleccionar todos los pacientes
            string sql = "SELECT id_paciente, nombre, calle, ciudad, cod_postal, telefono1, telefono2, telefono3 FROM Pacientes";

            try
            {
                connection.Open(); // Abrir la conexión
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                dataGridViewPacientes.Rows.Clear(); // Limpiar los datos previos

                while (reader.Read())
                {
                    // Agregar todas las columnas al DataGridView
                    dataGridViewPacientes.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }

                reader.Close(); // Cerrar el lector después de usarlo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
         
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {

            connection.Close(); // Cerrar la conexion
            this.Close(); // Ocultamos el formulario actual 
            Form1 form1 = new Form1(); // Creamos una instancia de Form1
            form1.Show();
        }

        private void buttonAgregarPaciente_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario para agregar un paciente
            FormularioPaciente formAgregarPaciente = new FormularioPaciente(this);
            formAgregarPaciente.ShowDialog(); // ShowDialog para que el usuario complete el formulario antes de continuar o no se haga nada

        }

        private void buttonBuscarPaciente_Click(object sender, EventArgs e)
        {
            connection.Open();

            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridViewPacientes.Rows.Clear();

            string sql = "SELECT * FROM pacientes WHERE nombre LIKE '%' + @Nombre + '%'"; // Para indicar que contiene el texto ingresado
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text.Trim());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Agregar fila al DataGridView con todas las columnas
                    dataGridViewPacientes.Rows.Add(
                        reader.GetInt32(0),   // ID 
                        reader.GetString(1),  // Nombre
                        reader.GetString(2),  // Calle
                        reader.GetString(3),  // Ciudad
                        reader.GetString(4),  // Código Postal
                        reader.GetString(5),  // Teléfono 1
                        reader.GetString(6),  // Teléfono 2
                        reader.GetString(7)   // Teléfono 3
                    );
                }
            }
            else
            {
                MessageBox.Show($"No existe el paciente {textBoxNombre.Text}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cerrar lector y conexión
            reader.Close();
            textBoxNombre.Text = ""; // Limpiar el buscador
            connection.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) // Opción de eliminar desde el menú contextual
        {
            // Obtener el ID del paciente seleccionado 
            int pacienteId = (int)dataGridViewPacientes.SelectedRows[0].Cells[0].Value; // Por que está en la primera columna
          
                try
                {
                    connection.Open();

                    string sql = "DELETE FROM Pacientes WHERE id_paciente = @PacienteId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@PacienteId", pacienteId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPacientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
          

         }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) // Opción de editar con el menú contextual
        {
            int pacienteId = (int)dataGridViewPacientes.SelectedRows[0].Cells[0].Value;
            string nombre = dataGridViewPacientes.SelectedRows[0].Cells[1].Value.ToString();
            string calle = dataGridViewPacientes.SelectedRows[0].Cells[2].Value.ToString();
            string ciudad = dataGridViewPacientes.SelectedRows[0].Cells[3].Value.ToString();
            string codPostal = dataGridViewPacientes.SelectedRows[0].Cells[4].Value.ToString();
            string telefono1 = dataGridViewPacientes.SelectedRows[0].Cells[5].Value.ToString();
            string telefono2 = dataGridViewPacientes.SelectedRows[0].Cells[6].Value.ToString();
            string telefono3 = dataGridViewPacientes.SelectedRows[0].Cells[7].Value.ToString();

            // Mostrar el formulario para editar el paciente, pasando estos datos para mostrarlos
            FormularioEditarPaciente formEditar = new FormularioEditarPaciente(pacienteId, nombre, calle, ciudad, codPostal, telefono1, telefono2, telefono3);


            if (formEditar.ShowDialog() == DialogResult.OK) // Si se ha llevado a cabo con éxito refrescar los datos
            {
                CargarPacientes();
            }
        }

        private void dataGridViewPacientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) // Para detectar que botón ha sido pulsado y sobre que fila
        {
            if (e.Button == MouseButtons.Right) // Si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // Verificamos si se hace clic sobre una fila válida
                {
                    // Seleccionar la fila clickeada
                    dataGridViewPacientes.ClearSelection();
                    dataGridViewPacientes.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridViewPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Para abrir los informes relacionados con el paciente.
        {
            if (e.RowIndex >= 0) // Verificamos que sea una fila válida
            {
                int idPaciente = (int)dataGridViewPacientes.Rows[e.RowIndex].Cells[0].Value; // Obtener el ID del paciente

                // Abrir el formulario de informes, pasando el ID del paciente
                FormularioInformes formInformes = new FormularioInformes(idPaciente);
                formInformes.ShowDialog();
            }
        }

        private void buttonMedicamentos_Click(object sender, EventArgs e)
        {
            
            FormularioMedicamentos formMedicamentos = new FormularioMedicamentos();
            formMedicamentos.ShowDialog(); 
        }
    }
}
