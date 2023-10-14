using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador_v1._0
{
    class conexion_bd
    {
       

        public static MySqlConnection establecerConexion()
        {

            

            string servidor = "localhost";
            string bd = "db_compilador";
            string usuario = "root";
            string password = "";
            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" +
                "database=" + bd + ";";

            try
            {
                MySqlConnection conex = new MySqlConnection
                (cadenaConexion);
                return conex;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: ", e.Message);
                return null;
            }
            
        }
        
        }
    }

