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
    public partial class FormularioEditarPaciente : Form
    {
        private int pacienteId;
        string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        SqlConnection connection;

        public FormularioEditarPaciente(int id, string nombre, string calle, string ciudad, string codPostal, string telefono1, string telefono2, string telefono3)
        {
            InitializeComponent();

            // Rellenar los campos con los datos actuales del paciente
            pacienteId = id;
            textBoxNombre.Text = nombre;
            textBoxCalle.Text = calle;
            textBoxCiudad.Text = ciudad;
            textBoxCodigoPostal.Text = codPostal;
            textBoxTelefono1.Text = telefono1;
            textBoxTelefono2.Text = telefono2;
            textBoxTelefono3.Text = telefono3;;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                // Establecer la conexión con la base de datos usando la cadena de conexión
                connection = new SqlConnection(cadenaDeConexion);
                connection.Open();

                // Actualizar los datos del paciente
                string sql = "UPDATE Pacientes SET nombre = @Nombre, calle = @Calle, ciudad = @Ciudad, cod_postal = @CodPostal, telefono1 = @Telefono1, telefono2 = @Telefono2, telefono3 = @Telefono3 WHERE id_paciente = @PacienteId";
                SqlCommand command = new SqlCommand(sql, connection);

                // Asignar los parámetros del SQL con los valores de los controles del formulario
                command.Parameters.AddWithValue("@PacienteId", pacienteId);
                command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                command.Parameters.AddWithValue("@Calle", textBoxCalle.Text);
                command.Parameters.AddWithValue("@Ciudad", textBoxCiudad.Text);
                command.Parameters.AddWithValue("@CodPostal", textBoxCodigoPostal.Text);
                command.Parameters.AddWithValue("@Telefono1", textBoxTelefono1.Text);
                command.Parameters.AddWithValue("@Telefono2", textBoxTelefono2.Text);
                command.Parameters.AddWithValue("@Telefono3", textBoxTelefono3.Text);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicar que el formulario se cerró con éxito
                    this.Close(); // Cerrar el formulario
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el paciente. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error ocurrido durante la conexión o actualización
                MessageBox.Show($"Error al actualizar el paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarnos de cerrar la conexión incluso si ocurre un error
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    
    }

}
