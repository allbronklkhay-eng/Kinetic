using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Si te sale error aquí, ve al paso "Nota de Librería" más abajo

namespace IMPORTADORAPOO
{
    public class Conexion
    {
        // Cadena de conexión a tu SQL Server local
       // private static string cadena = "Server=localhost; Database=Kinetic; Integrated Security=True;";
        private static string cadena = @"Server=.\SQLEXPRESS; Database=Kinetic; Integrated Security=True;";
        // NOTA: Si en tu PC usas LocalDB de Visual Studio en lugar de SQL Server Express, usa esta línea:
        //private static string cadena = @"Server=(localdb)\MSSQLLocalDB; Database=Kinetic; Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
