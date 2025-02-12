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
            string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
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
                    comboBoxMedicamentos.DisplayMember = "precio";  // Lo que se verá en el ComboBox
                    comboBoxMedicamentos.ValueMember = "id_medicamento"; // El valor real de cada opción
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
