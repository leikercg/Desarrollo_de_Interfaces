using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treapptment
{
    public class DatabaseConnection
    {
        // Variable privada para la conexión

        private static SqlConnection connection;

        // Método para obtener la conexión
        public static SqlConnection GetConnection()
        {

            if (connection == null)
            {
                connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Treapptment;Integrated Security=True;");

            }

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        // Método para cerrar la conexión cuando ya no se necesite
        public static void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }

}
