using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
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

            // Bloqueamos unos textos y botones al cargar la página
            textBoxIdTratamiento.Enabled = false;
            textBoxIdInforme.Text = _idInforme.ToString();
            textBoxIdInforme.Enabled = false;

            buttonEditar.Enabled = false;
        }

        private void CargarTratamientos()
        {
            connection = new SqlConnection(_cadenaDeConexion);
            string sql = @"SELECT lt.id_tratamiento, m.nombre, m.id_medicamento, lt.frecuencia_horas, lt.duracion_dias, 
                                 m.precio, m.descuento
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

                dataGridViewTratamientos.DataSource = dataTable; // Rellena el data grid de manera dinámica, sin tener que indicar numero de columnas en diseño

                // Cambiar nombres de columnas en el DataGridView, ya que de la manera anterior le da el nombre de la columna de la base de datos
                dataGridViewTratamientos.Columns["id_tratamiento"].HeaderText = "ID Tratamiento";
                dataGridViewTratamientos.Columns["nombre"].HeaderText = "Nombre del Medicamento";
                dataGridViewTratamientos.Columns["frecuencia_horas"].HeaderText = "Cada (horas)";
                dataGridViewTratamientos.Columns["Duracion_dias"].HeaderText = "Duración (días)";
                dataGridViewTratamientos.Columns["Precio"].HeaderText = "Precio por unidad(€)";
                dataGridViewTratamientos.Columns["Descuento"].HeaderText = "Descuento por unidad (€)";

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
            SqlConnection connection = new SqlConnection(_cadenaDeConexion);
            
                string sql = "SELECT id_medicamento, nombre, precio FROM Medicamentos"; // Ajusta según los datos que quieras mostrar

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // objeto que recoje los datos de una consulta y los rellena en otro
                    DataTable dataTable = new DataTable(); // rellena una data table
                    adapter.Fill(dataTable); // rellenar

                    // Asignamos los valores al ComboBox
                    comboBoxMedicamentos.DataSource = dataTable; // Extrae los valores de la date table
                    comboBoxMedicamentos.DisplayMember = "nombre";  // Lo que se verá en el ComboBox
                    comboBoxMedicamentos.ValueMember = "id_medicamento"; // El valor real de cada opción

                    // Suscribimos el evento SelectedIndexChanged
                    comboBoxMedicamentos.SelectedIndexChanged += new EventHandler(comboBoxMedicamentos_SelectedIndexChanged);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            connection.Close();
         }
        private void comboBoxMedicamentos_SelectedIndexChanged(object sender, EventArgs e) // Evento que maneja que hacer al ser seleccionado un item del combo
        {
            if (comboBoxMedicamentos.SelectedItem != null)
            {
                // Obtener el id del medicamento seleccionado
                int idMedicamento = Convert.ToInt32(((DataRowView)comboBoxMedicamentos.SelectedItem)["id_medicamento"]); // Seleccionar esa columna del combo asociado a la datatable

                // Establecer el valor del TextBox
                textBoxMedicamento.Text = idMedicamento.ToString();  // Si deseas mostrar el precio en formato moneda
            }
        }


        private void dataGridViewTratamientos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) // Detectar que boton y fila ha sido pulsada
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
            int tratamientoId = (int)dataGridViewTratamientos.SelectedRows[0].Cells[0].Value; // Ya que está en la primera columna


            try
            {
                connection.Open();
                string sql = "DELETE FROM linea_tratamiento WHERE id_tratamiento = @TratamientoId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@TratamientoId", tratamientoId);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tratamiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) // Opción del menú contextual editar
        {
            // Rellena los campos del formulario con los datos de la fila a editar
            textBoxIdTratamiento.Text = dataGridViewTratamientos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxMedicamento.Text = dataGridViewTratamientos.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFrecuencia.Text = dataGridViewTratamientos.SelectedRows[0].Cells[3].Value.ToString();
            textBoxDuracion.Text = dataGridViewTratamientos.SelectedRows[0].Cells[4].Value.ToString();

            buttonEditar.Enabled = true; // Lo habilitamos para poder editar
            buttonGuardar.Enabled = false; // para no guardar como otra fila la que estamos editando
            buttonCancelar.Visible = true; // Mosctrat boton de cancelar

        }

        private void limpiar() // Vacía los campos del formulario
        {
            textBoxIdInforme.Text = _idInforme.ToString();
            textBoxIdTratamiento.Text = "";
            textBoxMedicamento.Text = "";
            textBoxFrecuencia.Text = "";
            textBoxDuracion.Text = "";

        }
        public bool EsEntero(string texto) // Para validar que freceuncia y duración son numeros enteros
        {
            return int.TryParse(texto, out _); 
        }
        private void buttonGuardar_Click(object sender, EventArgs e) // Almacena en la base de datos los campos del formulario
        {
            String idTratamiento = textBoxIdTratamiento.Text;
            String idInforme = _idInforme.ToString();
            String medicamento = textBoxMedicamento.Text;
            String frecuencia = textBoxFrecuencia.Text;
            String duracion = textBoxDuracion.Text;

            bool esFrecuenciaValida = EsEntero(frecuencia); // validar si es entero
            bool esDuracionValida = EsEntero(duracion); // validar si es entero

             if ( string.IsNullOrEmpty(frecuencia) || string.IsNullOrEmpty(duracion) || string.IsNullOrEmpty(duracion))
            {
                MessageBox.Show("Medicamento ID, frecuencia y duración son campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método y no hace nada
            }
            if (!(esFrecuenciaValida && esDuracionValida)) // si no son enteros ambos campos
            {
                // Ambos valores son enteros válidos
                MessageBox.Show("Duración y frecuencia deben ser valores enteros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método y no hace nada

            }
            try
            {
                connection.Open();
                string sql = @"INSERT INTO linea_tratamiento 
                       (id_informe, id_medicamento, frecuencia_horas, duracion_dias)
                       VALUES
                       (@IdInforme, @medicamento, @frecuencia, @duracion)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdInforme", idInforme);
                command.Parameters.AddWithValue("@medicamento", medicamento);
                command.Parameters.AddWithValue("@CentroMedico", medicamento);
                command.Parameters.AddWithValue("@frecuencia", frecuencia);
                command.Parameters.AddWithValue("@duracion", duracion);

                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Tratamiento creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                limpiar(); // limpiamos formulario
                CargarTratamientos(); // Refrescamos los datos
                connection.Close();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Recogemos los valores de los campos
            String idTratamiento = textBoxIdTratamiento.Text;
            String idMedicamento = textBoxMedicamento.Text;
            String frecuencia = textBoxFrecuencia.Text;
            String duracion = textBoxDuracion.Text;

            bool esFrecuenciaValida = EsEntero(frecuencia); // validar si es entero
            bool esDuracionValida = EsEntero(duracion); // validar si es entero

            if (string.IsNullOrEmpty(idMedicamento) || string.IsNullOrEmpty(frecuencia) || string.IsNullOrEmpty(duracion))
            {
                MessageBox.Show("Medicamento ID, frecuencia y duración son campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método y no hace nada
            }
            if (!(esFrecuenciaValida && esDuracionValida)) // si no son enteros ambos campos
            {
                // Ambos valores son enteros válidos
                MessageBox.Show("Duración y frecuencia deben ser valores enteros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método y no hace nada

            }



            // Asignar la fecha de modificación con la fecha actual
            string fechaMod = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Para usar la fecha de la edición
            try
            {
                connection.Open();

                string sql = @"UPDATE linea_tratamiento SET 
                id_medicamento = @IdMedicamento,
                frecuencia_horas = @Frecuencia,
                duracion_dias = @Duracion
                WHERE id_tratamiento = @TratamientoID";


                SqlCommand command = new SqlCommand(sql, connection);
                command.Connection = connection;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TratamientoID", idTratamiento);
                command.Parameters.AddWithValue("@Duracion", duracion);
                command.Parameters.AddWithValue("@Frecuencia", frecuencia);
                command.Parameters.AddWithValue("@IdMedicamento", idMedicamento);
        

                int filasAfectadas = command.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Informe actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTratamientos();
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            buttonCancelar.Visible = false;
            buttonEditar.Enabled = false;
            limpiar();

        }
    }
}
