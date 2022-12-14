using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Models;
using System.Data.SqlClient;
using MySqlConnector;

namespace MarDeCortezDsk.Controllers
{
    public class BitacoraController : Controller
    {
        public List<Bitacora> Get()
        {

            List<Bitacora> List = new List<Bitacora>();
            string query = "select * from Bitacora order by IdBitacora";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Bitacora bitacora = new Bitacora()
                        {
                            IdBitacora = reader.GetString(0),
                            Proceso = reader.GetString(1),
                            Fecha = reader.GetString(2),
                            Usuario = reader.GetString(3),
                            Proveedor = reader.GetString(4)
                        };
                        List.Add(bitacora);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return List;

            }


        }
        public List<Bitacora> Get(string proveedor)
        {

            List<Bitacora> List = new List<Bitacora>();
            string query = $"select * from Bitacora where Proveedor like '{proveedor}%'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Bitacora bitacora = new Bitacora()
                        {
                            IdBitacora = reader.GetString(0),
                            Proceso = reader.GetString(1),
                            Fecha = reader.GetString(2),
                            Usuario = reader.GetString(3),
                            Proveedor = reader.GetString(4)
                        };
                        List.Add(bitacora);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return List;

            }
        }
    }
}
