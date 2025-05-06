using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace donaciones
{
    public class Conexion
    {
        private static string cadena = "server=localhost;user=root;password=michelle;database=donaciones;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
