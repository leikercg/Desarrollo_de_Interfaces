using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Treapptment
{
    public partial class Login : Form
    {
        string cadenaDeConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;";
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
            button1.Text = "Iniciar Sesión";
            button1.Click += new EventHandler(Button1_Click); // asignar evento al botón
        }

        // evento al hacer clic en el botón de login
        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide(); // oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        // metodo para validar usuario y contraseña en la base de datos
        private bool ValidarUsuario(string usuario, string contraseña)
        {
            connection = new SqlConnection(cadenaDeConexion);
            connection.Open();
            
                try
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE nombre = @Usuario AND password = @Contraseña";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = (int)cmd.ExecuteScalar();
                        connection.Close();
                        return count > 0; // devuelve true si el usuario existe
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            
        }
    }
}
