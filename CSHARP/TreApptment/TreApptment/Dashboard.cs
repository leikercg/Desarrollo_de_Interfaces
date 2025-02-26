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

        public void CargarPacientes() // carga los pacientes en la datagrid
        {
            // crear una nueva conexión a la base de datos
            connection = new SqlConnection(cadenaDeConexion);

            // crear el comando para seleccionar todos los pacientes
            string sql = "SELECT id_paciente, nombre, calle, ciudad, cod_postal, telefono1, telefono2, telefono3 FROM Pacientes";

            try
            {
                connection.Open(); // abrir la conexión
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                dataGridViewPacientes.Rows.Clear(); // limpiar los datos previos

                while (reader.Read())
                {
                    // agregar todas las columnas al DataGridView
                    dataGridViewPacientes.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }

                reader.Close(); // cerrar el lector después de usarlo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
         
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {

            connection.Close(); // cerrar la conexion
            this.Close(); // ocultamos el formulario actual 
            Login form1 = new Login(); // creamos una instancia de Form1
            form1.Show();
        }

        private void buttonAgregarPaciente_Click(object sender, EventArgs e)
        {
            // mostrar el formulario para agregar un paciente
            FormularioPaciente formAgregarPaciente = new FormularioPaciente(this);
            formAgregarPaciente.ShowDialog(); // showDialog para que el usuario complete el formulario antes de continuar o no se haga nada

        }

        private void buttonBuscarPaciente_Click(object sender, EventArgs e)
        {
            connection.Open();

            // limpiar el DataGridView antes de cargar nuevos datos
            dataGridViewPacientes.Rows.Clear();

            string sql = "SELECT * FROM pacientes WHERE nombre LIKE '%' + @Nombre + '%'"; // indicar que contiene el texto ingresado
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text.Trim());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Agregar fila al DataGridView con todas las columnas
                    dataGridViewPacientes.Rows.Add(
                        reader.GetInt32(0),  
                        reader.GetString(1),  
                        reader.GetString(2),  
                        reader.GetString(3),   
                        reader.GetString(4),    
                        reader.GetString(5),    
                        reader.GetString(6),   
                        reader.GetString(7)  
                    );
                }
            }
            else
            {
                MessageBox.Show($"No existe el paciente {textBoxNombre.Text}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // cerrar lector y conexión
            reader.Close();
            textBoxNombre.Text = ""; // limpiar el buscador
            connection.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) // opción de eliminar desde el menú contextual
        {
            if (dataGridViewPacientes.SelectedRows.Count == 0 || dataGridViewPacientes.SelectedRows[0].Index == -1)
            {
                MessageBox.Show("Seleccione un informe válido para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtener el ID del paciente seleccionado 
            int pacienteId = (int)dataGridViewPacientes.SelectedRows[0].Cells[0].Value; // por que está en la primera columna
          
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) // editar con el menú contextual
        {
            if (dataGridViewPacientes.SelectedRows.Count == 0 || dataGridViewPacientes.SelectedRows[0].Index == -1)
            {
                MessageBox.Show("Seleccione un informe válido para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pacienteId = (int)dataGridViewPacientes.SelectedRows[0].Cells[0].Value;
            string nombre = dataGridViewPacientes.SelectedRows[0].Cells[1].Value.ToString();
            string calle = dataGridViewPacientes.SelectedRows[0].Cells[2].Value.ToString();
            string ciudad = dataGridViewPacientes.SelectedRows[0].Cells[3].Value.ToString();
            string codPostal = dataGridViewPacientes.SelectedRows[0].Cells[4].Value.ToString();
            string telefono1 = dataGridViewPacientes.SelectedRows[0].Cells[5].Value.ToString();
            string telefono2 = dataGridViewPacientes.SelectedRows[0].Cells[6].Value.ToString();
            string telefono3 = dataGridViewPacientes.SelectedRows[0].Cells[7].Value.ToString();

            // mostrar el formulario para editar el paciente, pasando estos datos para mostrarlos
            FormularioEditarPaciente formEditar = new FormularioEditarPaciente(pacienteId, nombre, calle, ciudad, codPostal, telefono1, telefono2, telefono3);


            if (formEditar.ShowDialog() == DialogResult.OK) // si se ha llevado a cabo con éxito refrescar los datos
            {
                CargarPacientes();
            }
        }

        private void dataGridViewPacientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) // para detectar que botón ha sido pulsado y sobre que fila
        {
            if (e.Button == MouseButtons.Right) // si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // verificamos si se hace clic sobre una fila válida
                {
                    // seleccionar la fila clickeada
                    dataGridViewPacientes.ClearSelection();
                    dataGridViewPacientes.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridViewPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // para abrir los informes relacionados con el paciente.
        {
            if (e.RowIndex >= 0) // Verificamos que sea una fila válida
            {
                int idPaciente = (int)dataGridViewPacientes.Rows[e.RowIndex].Cells[0].Value; // obtener el ID del paciente

                // abrir el formulario de informes, pasando el ID del paciente
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
