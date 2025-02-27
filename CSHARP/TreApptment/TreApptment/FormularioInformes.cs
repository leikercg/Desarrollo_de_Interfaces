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

            // bloqueamos unos textos y botones
            textBoxIdInforme.Enabled = false;
            textBoxIdPaciente.Text = _idPaciente.ToString();
            textBoxIdPaciente.Enabled = false;
            textBoxFechaCrea.Enabled = false;
            textBoxFechaMod.Enabled = false;
            buttonEditar.Enabled = false;


        }

        private void CargarInformes() // cargar los informes en el datagrid
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

<<<<<<< HEAD
                dataGridViewInformes.DataSource = dataTable; // rellena el data grid de manera dinámica, sin tener que indicar numero de columnas en diseño
=======
                dataGridViewInformes.DataSource = dataTable; // ellena el data grid de manera dinámica, sin tener que indicar numero de columnas en diseño
>>>>>>> f7c285de91e1a13bd4005f294ec786a7349e358f
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

        private void dataGridViewInformes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // para abrir la ventana relacionada con el informe
        {
            if (e.RowIndex >= 0) // verifica que se haya hecho clic en una fila válida
            {
                int idInforme = Convert.ToInt32(dataGridViewInformes.Rows[e.RowIndex].Cells["id_informe"].Value);

                // abre el formulario de tratamientos y le pasa el idInforme
                FormularioTratamientos formTratamientos = new FormularioTratamientos(idInforme);
                formTratamientos.ShowDialog(); // mostrar como ventana modal
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // id del informe seleccionado
            int informeId = (int)dataGridViewInformes.SelectedRows[0].Cells[0].Value; // ya que esta en primera columna
=======
            if (dataGridViewInformes.SelectedRows.Count == 0 || dataGridViewInformes.SelectedRows[0].Index == -1)
            {
                MessageBox.Show("Seleccione un informe válido para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ID del informe seleccionado
            int informeId = (int)dataGridViewInformes.SelectedRows[0].Cells[0].Value; // ya que está en primera columna
>>>>>>> f7c285de91e1a13bd4005f294ec786a7349e358f

            try
            {
                connection.Open();

                string sql = "DELETE FROM informes WHERE id_informe = @InformeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@InformeId", informeId);

                // ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Informe eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void editarToolStripMenuItem_Click(object sender, EventArgs e) // opción de editar en el menu contextual
        {
            if (dataGridViewInformes.SelectedRows.Count == 0 || dataGridViewInformes.SelectedRows[0].Index == -1)
            {
                MessageBox.Show("Seleccione un informe válido para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // rellenamos los campos con la fina a editar
            textBoxIdInforme.Text = dataGridViewInformes.SelectedRows[0].Cells[0].Value.ToString();
            textBoxIdPaciente.Text = dataGridViewInformes.SelectedRows[0].Cells[1].Value.ToString();
            textBoxFechaCrea.Text= dataGridViewInformes.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFechaMod.Text= dataGridViewInformes.SelectedRows[0].Cells[3].Value.ToString();
            textBoxMedico.Text = dataGridViewInformes.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCentro.Text = dataGridViewInformes.SelectedRows[0].Cells[5].Value.ToString();
            textBoxMotivo.Text = dataGridViewInformes.SelectedRows[0].Cells[6].Value.ToString();
            textBoxRecomendaciones.Text = dataGridViewInformes.SelectedRows[0].Cells[7].Value.ToString();

            buttonEditar.Enabled = true; // habilitamos para poder editar
            buttonGuardar.Enabled = false; // para no guardar como otra fila la que estamos editando

            // activamos el boton de cancelar
            buttonCancelar.Visible = true;

        }
      

       
        private void buttonEditar_Click(object sender, EventArgs e) // edita en la base de datos
        {
            // Recogemos los valores de los campos
            String informeId = textBoxIdInforme.Text;
            String idPaciente = textBoxIdPaciente.Text;
            String nombreMedico = textBoxMedico.Text;
            String centroMedico = textBoxCentro.Text;
            String motivo = textBoxMotivo.Text;
            String recomendaciones = textBoxRecomendaciones.Text;

            if (string.IsNullOrEmpty(nombreMedico))
            {
                nombreMedico = "Dr. Leiker"; // valor por defecto
            }
            if (string.IsNullOrEmpty(centroMedico))
            {
                centroMedico = "Palafox"; // valor por defecto
            }
            // Si no está el motivo de la visita 
            if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show("El motivo no puede estar vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // detener la ejecución del método
            }

            // Asignar la fecha de modificación con la fecha actual
            string fechaMod = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // para usar la fecha de la edición
            try
            {
                connection.Open();

                string sql = @"UPDATE Informes SET 
                id_paciente = @IdPaciente,
                nombre_medico = @NombreMedico,
                centro_medico = @CentroMedico,
                motivo = @Motivo,
                recomendaciones = @Recomendaciones,
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
                //command.Parameters.AddWithValue("@FechaCrea", fechaCrea);
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
                buttonGuardar.Enabled = true; // habilitamos de nuevo el boton de guardar
                buttonEditar.Enabled = false;
                limpiar(); // Limpia los campos
                connection.Close();
                buttonCancelar.Visible = false;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // recogemos los valores de los campos
            String idPaciente = textBoxIdPaciente.Text;
            String nombreMedico = textBoxMedico.Text;
            String centroMedico = textBoxCentro.Text;
            String motivo = textBoxMotivo.Text;
            String recomendaciones = textBoxRecomendaciones.Text;

            if (string.IsNullOrEmpty(nombreMedico))
            {
                nombreMedico = "Dr. Leiker"; // para valor por defecto
            }
            if (string.IsNullOrEmpty(centroMedico))
            {
                centroMedico = "Palafox"; // para valor por defecto
            }

            // Si no está el motivo de la visita 
            if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show("El motivo no puede estar vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // detener la ejecución
            }

            try
            {
                connection.Open();

                // consulta SQL para crear un nuevo informe
                string sql = @"INSERT INTO Informes 
                       (id_paciente, nombre_medico, centro_medico, motivo, recomendaciones)
                       VALUES
                       (@IdPaciente, @NombreMedico, @CentroMedico, @Motivo, @Recomendaciones)";

                SqlCommand command = new SqlCommand(sql, connection);

                // agregar parámetros a la consulta
                command.Parameters.AddWithValue("@IdPaciente", idPaciente);
                command.Parameters.AddWithValue("@NombreMedico", nombreMedico);
                command.Parameters.AddWithValue("@CentroMedico", centroMedico);
                command.Parameters.AddWithValue("@Motivo", motivo);
                command.Parameters.AddWithValue("@Recomendaciones", recomendaciones);

              
                // ejecutar el comando
                int filasAfectadas = command.ExecuteNonQuery();

                // verificar si se insertó un nuevo informe
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


        private void dataGridViewInformes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) // detectar que boton es pulsado para el menú contextual
        {
            if (e.Button == MouseButtons.Right) // si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // vificamos si se hace clic sobre una fila válida
                {
                    // sleccionar la fila clickeada
                    dataGridViewInformes.ClearSelection();
                    dataGridViewInformes.Rows[e.RowIndex].Selected = true;
                }
            }

        }

        private void limpiar() // pra limpiar los campos
        {
            textBoxIdInforme.Text = "";
            textBoxIdPaciente.Text = _idPaciente.ToString();
            textBoxFechaCrea.Text = "";
            textBoxFechaMod.Text = "";
            textBoxMedico.Text = "";
            textBoxCentro.Text = "";
            textBoxMotivo.Text = "";
            textBoxRecomendaciones.Text = "";

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            buttonCancelar.Visible = false;
            buttonEditar.Enabled = false;

            limpiar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;  // usr .Date para asegurar que solo se considere la fecha sin la hora
            int IdPaciente = _idPaciente;
            buttonVerTodos.Visible = true
                .
                
                
                ;
            try
            {
                connection.Open();

                // umos CAST para comparar solo la fecha en SQL, sin considerar la hora
                string sql = @"SELECT * FROM informes WHERE CAST(fecha_creacion AS DATE) = @fechaSeleccionada";
                SqlCommand command = new SqlCommand(sql, connection);

                // psamos la fecha como DateTime, no como string
                command.Parameters.AddWithValue("@fechaSeleccionada", fechaSeleccionada);
                command.Parameters.AddWithValue("@idPaciente", IdPaciente);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    limpiar();
                    reader.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewInformes.DataSource = dataTable; // rellena el data grid de manera dinámica
                }
                else
                {
                    MessageBox.Show("No hay informes con esa fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonVerTodos_Click(object sender, EventArgs e)
        {
            limpiar();
            CargarInformes();
            buttonVerTodos.Visible = false;
        }
    }
}
