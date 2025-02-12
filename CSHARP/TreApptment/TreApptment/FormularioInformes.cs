using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Treapptment
{
    public partial class FormularioInformes : Form
    {
        private int _idPaciente;
        private string _cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        private SqlConnection connection;

        public FormularioInformes(int idPaciente)
        {
            InitializeComponent();
            _idPaciente = idPaciente;
            CargarInformes();

            textBoxIdInforme.Enabled = false;
            textBoxIdPaciente.Text = _idPaciente.ToString();
            textBoxIdPaciente.Enabled = false;
        }

        private void CargarInformes()
        {
            connection = new SqlConnection(_cadenaDeConexion);
            string sql = "SELECT * FROM Informes WHERE id_paciente = @IdPaciente";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdPaciente", _idPaciente);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewInformes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar informes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewInformes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya hecho clic en una fila válida
            {
                int idInforme = Convert.ToInt32(dataGridViewInformes.Rows[e.RowIndex].Cells["id_informe"].Value);

                // Abre el formulario de tratamientos y le pasa el idInforme
                FormularioTratamientos formTratamientos = new FormularioTratamientos(idInforme);
                formTratamientos.ShowDialog(); // Mostrar como ventana modal
            }

        }

        private void FormularioInformes_Load(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el ID del informe seleccionado (supuesto que el ID está en la primera columna)
            int informeId = (int)dataGridViewInformes.SelectedRows[0].Cells[0].Value;


            // Conectar con la base de datos
            try
            {
                connection.Open();

                // Crear el comando SQL para eliminar
                string sql = "DELETE FROM informes WHERE id_informe = @InformeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@InformeId", informeId);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Informe eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de pacientes después de la eliminación
                    CargarInformes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Obtener el ID del paciente seleccionado
            textBoxIdInforme.Text = dataGridViewInformes.SelectedRows[0].Cells[0].Value.ToString();
            textBoxIdPaciente.Text = dataGridViewInformes.SelectedRows[0].Cells[1].Value.ToString();
            textBoxFechaCrea.Text= dataGridViewInformes.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFechaMod.Text= dataGridViewInformes.SelectedRows[0].Cells[3].Value.ToString();
            textBoxMedico.Text = dataGridViewInformes.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCentro.Text = dataGridViewInformes.SelectedRows[0].Cells[5].Value.ToString();
            textBoxMotivo.Text = dataGridViewInformes.SelectedRows[0].Cells[6].Value.ToString();
            textBoxRecomendaciones.Text = dataGridViewInformes.SelectedRows[0].Cells[7].Value.ToString();

            
        
    }
      

        private void dataGridViewInformes_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // Verificamos si se hace clic sobre una fila válida
                {
                    // Seleccionar la fila clickeada
                    dataGridViewInformes.ClearSelection();
                    dataGridViewInformes.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            
            String informeId = textBoxIdInforme.Text;
            String idPaciente = textBoxIdPaciente.Text;
            String nombreMedico = textBoxMedico.Text;
            String centroMedico = textBoxCentro.Text;
            String motivo = textBoxMotivo.Text;
            String recomendaciones = textBoxRecomendaciones.Text;
            String fechaCrea = textBoxFechaCrea.Text;
            String fechaMod = textBoxFechaMod.Text;

            try
            {
                connection.Open();

                string sql = @"UPDATE Informes SET 
                id_paciente = @IdPaciente,
                nombre_medico = @NombreMedico,
                centro_medico = @CentroMedico,
                motivo = @Motivo,
                recomendaciones = @Recomendaciones,
                fecha_creacion = @FechaCrea,
                fecha_modificacion = @FechaMod
                WHERE id_informe = @InformeId";
                SqlCommand command = new SqlCommand(sql, connection);




                command.Connection = connection;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@InformeId", informeId);
                command.Parameters.AddWithValue("@IdPaciente", idPaciente);
                command.Parameters.AddWithValue("@NombreMedico", nombreMedico);
                command.Parameters.AddWithValue("@CentroMedico", centroMedico);
                command.Parameters.AddWithValue("@Motivo", motivo);
                command.Parameters.AddWithValue("@Recomendaciones", recomendaciones);
                command.Parameters.AddWithValue("@FechaCrea", fechaCrea);
                command.Parameters.AddWithValue("@FechaMod", fechaMod);



                int filasAfectadas = command.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Informe actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInformes();
                }
                else
                {
                    MessageBox.Show("No se encontró el informe a actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limpiar();
                connection.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String idPaciente = textBoxIdPaciente.Text;
            String nombreMedico = textBoxMedico.Text;
            String centroMedico = textBoxCentro.Text;
            String motivo = textBoxMotivo.Text;
            String recomendaciones = textBoxRecomendaciones.Text;
            String fechaCrea = textBoxFechaCrea.Text;
            String fechaMod = textBoxFechaMod.Text;

            try
            {
                connection.Open();

                // Consulta SQL para crear un nuevo informe
                string sql = @"INSERT INTO Informes 
                       (id_paciente, nombre_medico, centro_medico, motivo, recomendaciones, fecha_creacion, fecha_modificacion)
                       VALUES
                       (@IdPaciente, @NombreMedico, @CentroMedico, @Motivo, @Recomendaciones, @FechaCrea, @FechaMod)";

                SqlCommand command = new SqlCommand(sql, connection);

                // Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@IdPaciente", idPaciente);
                command.Parameters.AddWithValue("@NombreMedico", nombreMedico);
                command.Parameters.AddWithValue("@CentroMedico", centroMedico);
                command.Parameters.AddWithValue("@Motivo", motivo);
                command.Parameters.AddWithValue("@Recomendaciones", recomendaciones);
                command.Parameters.AddWithValue("@FechaCrea", fechaCrea);  // Usar la fecha proporcionada
                command.Parameters.AddWithValue("@FechaMod", fechaMod);    // Usar la fecha proporcionada

                // Ejecutar el comando
                int filasAfectadas = command.ExecuteNonQuery();

                // Verificar si se insertó un nuevo informe
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Informe creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInformes();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el informe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limpiar();
                connection.Close();
            }
        }


        private void dataGridViewInformes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // Verificamos si se hace clic sobre una fila válida
                {
                    // Seleccionar la fila clickeada
                    dataGridViewInformes.ClearSelection();
                    dataGridViewInformes.Rows[e.RowIndex].Selected = true;
                }
            }

        }

        private void limpiar()
        {
            // Obtener el ID del paciente seleccionado
            textBoxIdInforme.Text = "";
            textBoxIdPaciente.Text = _idPaciente.ToString();
            textBoxFechaCrea.Text = "";
            textBoxFechaMod.Text = "";
            textBoxMedico.Text = "";
            textBoxCentro.Text = "";
            textBoxMotivo.Text = "";
            textBoxRecomendaciones.Text = "";

        }
    }
}
