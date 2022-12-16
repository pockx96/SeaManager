using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Controllers;
using MySqlConnector;
using System.Runtime.InteropServices;

namespace MarDeCortezDsk.Controllers
{
    public class InventariosController:Controller
    {
        public List<Inventario> Get(string Proveedor)
        {

            List<Inventario> List = new List<Inventario>();
            string query = $"select * from Inventarios where Proveedor = '{Proveedor}' order by IdInventario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Inventario inventario = new Inventario()
                        {
                            IdInventario = reader.GetString(0),
                            Proveedor = reader.GetString(1),
                            Producto =  reader.GetString(2),
                            Presentacion =  reader.GetString(3),
                            Cantidad = reader.GetInt32(4),
                            Kilos = reader.GetFloat(5)
                        };
                        List.Add(inventario);

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

        public Inventario GetById(string Id)
        {
            Inventario inventario = new Inventario();
            string query = $"select * from Inventarios where IdInventario = '{Id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        inventario = new Inventario()
                        {
                            IdInventario = reader.GetString(0),
                            Proveedor = reader.GetString(1),
                            Producto = reader.GetString(2),
                            Presentacion = reader.GetString(3),
                            Cantidad = reader.GetInt32(4),
                            Kilos = reader.GetFloat(5)
                        };

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);
                }

                return inventario;

            }
        }


        public void Update(Inventario inventario , int cantidad , float kilos)
        {

            float newKilos = inventario.Kilos - kilos;
            int newCantidad = inventario.Cantidad - cantidad;

            string query = $"update Inventarios set Cantidad = {newCantidad} , Kilos = {newKilos} where Presentacion = '{inventario.Presentacion}' and Producto = '{inventario.Producto}' and Proveedor = '{inventario.Proveedor}'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);
                }
            }

        }
    }
}
