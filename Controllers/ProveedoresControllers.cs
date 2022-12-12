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
    public class ProveedoresControllers : Controller
    {

        public List<Proveedor> Get()
        {
            List<Proveedor> proveedors = new List<Proveedor>();
            string query = "select * from Proveedor order by NombreProveedor";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Proveedor oproveedor = new Proveedor();
                        oproveedor.id_proveedor = reader.GetString(0);
                        oproveedor.nombre_proveedor = reader.GetString(1);
                        oproveedor.telefono_proveedor = reader.GetString(2);
                        proveedors.Add(oproveedor);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return proveedors;

            }
        
        }

        public Proveedor Get(string id)
        {
            Proveedor oproveedor = new Proveedor();
            string query = $"select * from Proveedor where IdProveedor = '{id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        oproveedor.id_proveedor = reader.GetString(0);
                        oproveedor.nombre_proveedor = reader.GetString(1);
                        oproveedor.telefono_proveedor = reader.GetString(2);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return oproveedor;

            }

        }


        public void Update(Proveedor proveedor)
        {
            string Idproveedor = proveedor.id_proveedor;
            string NombreProvedor = proveedor.nombre_proveedor;
            string TelefonoProvedor = proveedor.telefono_proveedor;
            string query = $"update Proveedor set NombreProveedor='{NombreProvedor}',TelefonoProveedor='{TelefonoProvedor}' where IdProveedor = '{Idproveedor}'";

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



        public void Post(Proveedor proveedor)
        {
            string Idproveedor = NewId();
            string NombreProv = proveedor.nombre_proveedor;
            string TelefonoProv = proveedor.telefono_proveedor;
            string query = "insert into Proveedor(IdProveedor, NombreProveedor, TelefonoProveedor) values" + "(@Idproveedor, @NombreProv, @TelefonoProv)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Idproveedor", Idproveedor);
                command.Parameters.AddWithValue("@NombreProv", NombreProv);
                command.Parameters.AddWithValue("@TelefonoProv", TelefonoProv);

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

        public void Delete(string id)
        {
            string query = $"delete from Proveedor where IdProveedor = '{id}'";

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
        public string NewId()
        {
            ProveedoresControllers proveedorController = new ProveedoresControllers();
            List<Proveedor> fichaList = proveedorController.Get();
            int index = fichaList.Count ;
            string idString = Convert.ToString(fichaList.Count + 1 );

            if (idString.Length == 1)
            {
                return "P0" + idString;
            }
            else if (idString.Length == 2)
            {
                return "P" + idString;
            }
            return idString;

        }
    }
}
