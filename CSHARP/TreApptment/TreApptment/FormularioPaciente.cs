using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Treapptment
{
    public partial class FormularioPaciente : Form
    {
        private Dashboard _dashboard; // Para almacenar la referencia de Dashboard
        string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        SqlConnection connection;


        public FormularioPaciente(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }

        // Evento para agregar el paciente
            private void buttonGuardar_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(cadenaDeConexion);

            string nombre = textBoxNombre.Text.Trim();
            string calle = textBoxCalle.Text.Trim();
            string ciudad = textBoxCiudad.Text.Trim();
            string codPostal = textBoxCodigoPostal.Text.Trim();
            string telefono1 = textBoxTelefono1.Text.Trim();
            string telefono2 = textBoxTelefono2.Text.Trim();
            string telefono3 = textBoxTelefono3.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"INSERT INTO Pacientes (nombre, calle, ciudad, cod_postal, telefono1, telefono2, telefono3) 
                             VALUES (@Nombre, @Calle, @Ciudad, @CodPostal, @Telefono1, @Telefono2, @Telefono3)";


            try
            {
                connection.Open(); // Abre la conexión antes de ejecutar la consulta
                SqlCommand cmd = new SqlCommand(sql, connection);
                
                    cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 100).Value = nombre;
                    cmd.Parameters.Add("@Calle", System.Data.SqlDbType.VarChar, 200).Value = calle;
                    cmd.Parameters.Add("@Ciudad", System.Data.SqlDbType.VarChar, 100).Value = ciudad;
                    cmd.Parameters.Add("@CodPostal", System.Data.SqlDbType.VarChar, 10).Value = codPostal;
                    cmd.Parameters.Add("@Telefono1", System.Data.SqlDbType.VarChar, 20).Value = telefono1;
                    cmd.Parameters.Add("@Telefono2", System.Data.SqlDbType.VarChar, 20).Value = telefono2;
                    cmd.Parameters.Add("@Telefono3", System.Data.SqlDbType.VarChar, 20).Value = telefono3;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paciente agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    _dashboard.CargarPacientes();


                    this.Close(); // Cerrar formulario
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el paciente. Inténtalo nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // Cerrar la conexión al finalizar
            }
        }

 
    }
}
