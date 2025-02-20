using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Treapptment
{
    public partial class FormularioMedicamentos : Form
    {
        private string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        private SqlConnection connection;

        public FormularioMedicamentos()
        {
            InitializeComponent();
            CargarMedicamentos();

            // Bloqueamos unos textos y botones
            buttonEditar.Enabled = false;
        }

        private void CargarMedicamentos()
        {
            connection = new SqlConnection(cadenaDeConexion);
            string sql = "SELECT id_medicamento, nombre, precio, descuento FROM Medicamentos";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                // SqlDataAdapter para llenar un DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // El DataTable como DataSource del DataGridView
                dataGridViewMedicamentos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén rellenados
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescuento.Text))
            {
                MessageBox.Show("Todos los campos deben estar rellenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el precio y el descuento sean números válidos con coma decimal
            if (!decimal.TryParse(textBoxPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido (ejemplo: 12,50).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxDescuento.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal descuento))
            {
                MessageBox.Show("El descuento debe ser un número válido (ejemplo: 0,10).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = textBoxNombre.Text;

            // Verificar si el nombre ya existe en la base de datos
            string sqlVerificar = "SELECT COUNT(*) FROM Medicamentos WHERE nombre = @Nombre";
            string sqlInsertar = "INSERT INTO Medicamentos (nombre, precio, descuento) VALUES (@Nombre, @Precio, @Descuento)";

            try
            {
                connection.Open();

                // Verificar si el nombre ya existe
                SqlCommand commandVerificar = new SqlCommand(sqlVerificar, connection);
                commandVerificar.Parameters.AddWithValue("@Nombre", nombre);
                int count = (int)commandVerificar.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("El nombre del medicamento ya existe. No se puede agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el nombre no existe, proceder con la inserción
                SqlCommand commandInsertar = new SqlCommand(sqlInsertar, connection);
                commandInsertar.Parameters.AddWithValue("@Nombre", nombre);
                commandInsertar.Parameters.AddWithValue("@Precio", precio);
                commandInsertar.Parameters.AddWithValue("@Descuento", descuento);
                commandInsertar.ExecuteNonQuery();

                MessageBox.Show("Medicamento creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMedicamentos();
                limpiar(); // Limpiar los campos después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el medicamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una fila en el DataGridView
            if (dataGridViewMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un medicamento para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que todos los campos estén rellenados
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescuento.Text))
            {
                MessageBox.Show("Todos los campos deben estar rellenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el precio y el descuento sean números válidos con coma decimal
            if (!decimal.TryParse(textBoxPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido (ejemplo: 12,50).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxDescuento.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal descuento))
            {
                MessageBox.Show("El descuento debe ser un número válido (ejemplo: 0,10).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idMedicamento = (int)dataGridViewMedicamentos.SelectedRows[0].Cells[0].Value;
            string nombre = textBoxNombre.Text;
            string sql = "UPDATE Medicamentos SET nombre = @Nombre, precio = @Precio, descuento = @Descuento WHERE id_medicamento = @IdMedicamento";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Descuento", descuento);
                command.Parameters.AddWithValue("@IdMedicamento", idMedicamento);
                command.ExecuteNonQuery();

                MessageBox.Show("Medicamento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMedicamentos();
                buttonEditar.Enabled = false;
                buttonCancelar.Visible = false;
                buttonBuscar.Enabled = true;

                limpiar(); // Limpiar los campos después de editar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el medicamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void limpiar()
        {
            // Limpiar los campos del formulario
            textBoxIdMedicamento.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxDescuento.Text = "";
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxBusqueda.Text.Trim();
            string sql = "SELECT id_medicamento, nombre, precio, descuento FROM Medicamentos WHERE nombre LIKE '%' + @Nombre + '%'";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable como DataSource del DataGridView
                dataGridViewMedicamentos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Rellenamos los campos con la fila a editar
            textBoxIdMedicamento.Text = dataGridViewMedicamentos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxNombre.Text = dataGridViewMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrecio.Text = dataGridViewMedicamentos.SelectedRows[0].Cells[2].Value.ToString();
            textBoxDescuento.Text = dataGridViewMedicamentos.SelectedRows[0].Cells[3].Value.ToString();

            textBoxBusqueda.Enabled = false;
            buttonEditar.Enabled = true; // Lo habilitamos para poder editar
            buttonGuardar.Enabled = false; // Para no guardar como otra fila la que estamos editando
            buttonBuscar.Enabled = false;

            // Activamos el botón de cancelar
            buttonCancelar.Visible = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ID del medicamento seleccionado
            int medicamento_ID = (int)dataGridViewMedicamentos.SelectedRows[0].Cells[0].Value;

            try
            {
                connection.Open();

                string sql = "DELETE FROM Medicamentos WHERE id_medicamento = @MedicamentoId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MedicamentoId", medicamento_ID);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Medicamento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMedicamentos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar medicamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewMedicamentos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Si el botón clickeado es el derecho
            {
                if (e.RowIndex >= 0) // Verificamos si se hace clic sobre una fila válida
                {
                    // Seleccionar la fila clickeada
                    dataGridViewMedicamentos.ClearSelection();
                    dataGridViewMedicamentos.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            buttonCancelar.Visible = false;
            buttonEditar.Enabled = false;
            textBoxBusqueda.Enabled = true;
            buttonBuscar.Enabled = true;


            limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Llamar al método de búsqueda
            textBoxBusqueda_TextChanged(sender, e);
        }
    }
}