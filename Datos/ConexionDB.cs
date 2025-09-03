using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos{
    public class conexionDB{
        public MySqlConnectionStringBuilder cadenaConexion;

        public conexionDB() 
        {

            cadenaConexion = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "parqueadero",
                UserID = "root",
                Password = "",
            };
            

            

        } 
    }
}
