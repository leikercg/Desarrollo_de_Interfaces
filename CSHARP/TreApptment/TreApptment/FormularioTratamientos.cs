using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Treapptment
{
    public partial class FormularioTratamientos : Form
    {
        private int _idInforme;
        private string _cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        private SqlConnection connection;

        public FormularioTratamientos(int idInforme)
        {
            InitializeComponent();
            _idInforme = idInforme;
            CargarTratamientos();
            CargarMedicamentos();
            textBoxIdTratamiento.Enabled = false;
            textBoxIdInforme.Text = _idInforme.ToString();
            textBoxIdInforme.Enabled = false;
        }

        private void CargarTratamientos()
        {
            connection = new SqlConnection(_cadenaDeConexion);
            string sql = @"SELECT lt.id_tratamiento, lt.frecuencia_horas, lt.duracion_dias, 
                                  m.id_medicamento, m.precio, m.descuento
                           FROM Linea_Tratamiento lt
                           LEFT JOIN Medicamentos m ON lt.id_medicamento = m.id_medicamento
                           WHERE lt.id_informe = @IdInforme";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdInforme", _idInforme);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewTratamientos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CargarMedicamentos()
        {
//            string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(_cadenaDeConexion))
            {
                string sql = "SELECT id_medicamento, precio FROM Medicamentos"; // Ajusta según los datos que quieras mostrar

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignamos los valores al ComboBox
                    comboBoxMedicamentos.DataSource = dataTable;
                    comboBoxMedicamentos.DisplayMember = "id_medicamento";  // Lo que se verá en el ComboBox
                    comboBoxMedicamentos.ValueMember = "id_medicamento"; // El valor real de cada opción

                    // Suscribimos el evento SelectedIndexChanged
                    comboBoxMedicamentos.SelectedIndexChanged += new EventHandler(comboBoxMedicamentos_SelectedIndexChanged);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBoxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMedicamentos.SelectedItem != null)
            {
                // Obtener el id del medicamento seleccionado
                int idMedicamento = Convert.ToInt32(((DataRowView)comboBoxMedicamentos.SelectedItem)["id_medicamento"]);

                // Establecer el valor del TextBox
                textBoxMedicamento.Text = idMedicamento.ToString();  // Si deseas mostrar el precio en formato moneda
            }
        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTratamientos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) // Si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // Verificamos si se hace clic sobre una fila válida
                {
                    // Seleccionar la fila clickeada
                    dataGridViewTratamientos.ClearSelection();
                    dataGridViewTratamientos.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el ID del informe seleccionado (supuesto que el ID está en la primera columna)
            int tratamientoId = (int)dataGridViewTratamientos.SelectedRows[0].Cells[0].Value;


            // Conectar con la base de datos
            try
            {
                connection.Open();

                // Crear el comando SQL para eliminar
                string sql = "DELETE FROM linea_tratamiento WHERE id_tratamiento = @TratamientoId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@TratamientoId", tratamientoId);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tratamiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de pacientes después de la eliminación
                    CargarTratamientos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el tratamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar tratamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Obtener el ID del paciente seleccionado
            textBoxIdTratamiento.Text = dataGridViewTratamientos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxMedicamento.Text = dataGridViewTratamientos.SelectedRows[0].Cells[3].Value.ToString();
            textBoxFrecuencia.Text = dataGridViewTratamientos.SelectedRows[0].Cells[1].Value.ToString();
            textBoxDuracion.Text = dataGridViewTratamientos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void limpiar()
        {
            // Obtener el ID del paciente seleccionado
            textBoxIdInforme.Text = _idInforme.ToString();
            textBoxIdTratamiento.Text = "";
            textBoxMedicamento.Text = "";
            textBoxFrecuencia.Text = "";
            textBoxDuracion.Text = "";
 
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String idTratamiento = textBoxIdTratamiento.Text;
            String idInforme = _idInforme.ToString();
            String medicamento = textBoxMedicamento.Text;
            String frecuencia = textBoxFrecuencia.Text;
            String duracion = textBoxDuracion.Text;
   

            try
            {
                connection.Open();

                // Consulta SQL para crear un nuevo informe
                string sql = @"INSERT INTO linea_tratamiento 
                       (id_informe, id_medicamento, frecuencia_horas, duracion_dias)
                       VALUES
                       (@IdInforme, @medicamento, @frecuencia, @duracion)";

                SqlCommand command = new SqlCommand(sql, connection);

                // Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@IdInforme", idInforme);
                command.Parameters.AddWithValue("@medicamento", medicamento);
                command.Parameters.AddWithValue("@CentroMedico", medicamento);
                command.Parameters.AddWithValue("@frecuencia", frecuencia);
                command.Parameters.AddWithValue("@duracion", duracion);


                // Ejecutar el comando
                int filasAfectadas = command.ExecuteNonQuery();

                // Verificar si se insertó un nuevo informe
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Tratamiento creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // CargarInformes();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el tratamiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el tratamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limpiar();
                CargarTratamientos();
                connection.Close();
            }
        }
    }
}
