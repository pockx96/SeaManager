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
    internal class PescadoController : Controller
    {

        public List<Pescado> Get()
        {
            List<Pescado> List = new List<Pescado>();
            string query = "select * from pescado order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pescado pescado = new Pescado();
                        pescado.IdProducto = reader.GetString(0);
                        pescado.FolioEntrada = reader.GetString(1);
                        pescado.Tipo_producto = reader.GetString(2);
                        pescado.Almacenaje = reader.GetString(3);
                        pescado.Presentacion = reader.GetString(4);
                        pescado.Kilos = reader.GetFloat(5);
                        pescado.Cantidad = reader.GetInt32(6);
                        List.Add(pescado);

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

        public Pescado Get(string id)
        {
            Pescado pescado = new Pescado();
            string query = "select * from pescado where IdProducto = '" + id + "' order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        pescado.IdProducto = reader.GetString(0);
                        pescado.FolioEntrada = reader.GetString(1);
                        pescado.Tipo_producto = reader.GetString(2);
                        pescado.Almacenaje = reader.GetString(3);
                        pescado.Presentacion = reader.GetString(4);
                        pescado.Kilos = reader.GetFloat(5);
                        pescado.Cantidad = reader.GetInt32(6);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return pescado;

            }
        }
        public Pescado Get(Pescado pescadoStock)
        {
            Pescado pescado = new Pescado();
            string query = $"select * from pescado where  Almacenaje = 'Tienda' and TipoProducto = '{pescadoStock.Tipo_producto}' and Presentacion = '{pescadoStock.Presentacion}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        pescado.IdProducto = reader.GetString(0);
                        pescado.FolioEntrada = reader.GetString(1);
                        pescado.Tipo_producto = reader.GetString(2);
                        pescado.Almacenaje = reader.GetString(3);
                        pescado.Presentacion = reader.GetString(4);
                        pescado.Kilos = reader.GetFloat(5);
                        pescado.Cantidad = reader.GetInt32(6);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return pescado;

            }
        }

        public List<Pescado> GetByFolio(string id)
        {
            List<Pescado> List = new List<Pescado>();
            string query = "select * from pescado where IdFolio = '" + id + "' order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pescado pescado = new Pescado();
                        pescado.IdProducto = reader.GetString(0);
                        pescado.FolioEntrada = reader.GetString(1);
                        pescado.Tipo_producto = reader.GetString(2);
                        pescado.Almacenaje = reader.GetString(3);
                        pescado.Presentacion = reader.GetString(4);
                        pescado.Kilos = reader.GetFloat(5);
                        pescado.Cantidad = reader.GetInt32(6);
                        List.Add(pescado);

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

        public List<Pescado> GetByProveedor(string almacenaje)
        {
            List<Pescado> List = new List<Pescado>();
            string query = "select * from pescado where Almacenaje = '" + almacenaje + "' order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pescado pescado = new Pescado();
                        pescado.IdProducto = reader.GetString(0);
                        pescado.FolioEntrada = reader.GetString(1);
                        pescado.Tipo_producto = reader.GetString(2);
                        pescado.Almacenaje = reader.GetString(3);
                        pescado.Presentacion = reader.GetString(4);
                        pescado.Kilos = reader.GetFloat(5);
                        pescado.Cantidad = reader.GetInt32(6);
                        List.Add(pescado);

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


        public void Delete(string ficha)
        {
            string query = "delete from pescado where IdProducto = @ficha";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ficha", ficha);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

            }
        }

        
        public void Post(Pescado pescado)
        {
            string idProducto = NewId();
            string folioEntrada = pescado.FolioEntrada;
            string tipo_producto = pescado.Tipo_producto;
            float? kilos = pescado.Kilos;
            string almacenaje = pescado.Almacenaje;
            string presentacion = pescado.Presentacion;
            int cantidad = pescado.Cantidad;
            string query = "insert into pescado(IdProducto,IdFolio, TipoProducto, Kilos, Almacenaje, Presentacion, Cantidad) values" + "(@idProducto, @folioEntrada, @tipo_producto, @kilos, @almacenaje, @presentacion, @cantidad)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.Parameters.AddWithValue("@FolioEntrada", folioEntrada);
                command.Parameters.AddWithValue("@tipo_producto", tipo_producto);
                command.Parameters.AddWithValue("@kilos", kilos);
                command.Parameters.AddWithValue("@almacenaje", almacenaje);
                command.Parameters.AddWithValue("@presentacion", presentacion);
                command.Parameters.AddWithValue("@cantidad", cantidad);

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

        public void Update(Pescado pescado, bool SumaResta)
        {
            Pescado PescadoStock = Get(pescado);
            float? Kilos;
            int cantidad;
            if (SumaResta)
            {
                Kilos = pescado.Kilos + PescadoStock.Kilos;
                cantidad = pescado.Cantidad + PescadoStock.Cantidad;
            }
            else
            {
                Kilos = PescadoStock.Kilos - pescado.Kilos;
                cantidad = PescadoStock.Cantidad - pescado.Cantidad;
            }


            string query = $"update camaron set Kilos = {Kilos}, Cantidad = {cantidad} where Almacenaje = 'Tienda' and TipoProducto = '{pescado.Tipo_producto}' and Presentacion = '{pescado.Presentacion}'";
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
            PescadoController pescadoController = new PescadoController();
            List<Pescado> fichaList = pescadoController.Get();
            int index = fichaList.Count + 1;
            string indexString = Convert.ToString(index);

            if (indexString.Length == 1)
            {
                return "P0" + indexString;
            }
            else if (indexString.Length == 2)
            {
                return "P" + indexString;
            }
            return indexString;

        }


        public Pescado ConvertToPescado(Camaron camaron)
        {
            Pescado pescado = new Pescado
            {
                IdProducto = camaron.IdProducto,
                FolioEntrada = camaron.FolioEntrada,
                Tipo_producto = camaron.Tipo_producto,
                Presentacion = camaron.Presentacion + " " + camaron.Medida,
                Almacenaje = camaron.Almacenaje,
                Cantidad = camaron.Cantidad,
                Kilos = camaron.Kilos

            };
            return pescado;
        }

        public List<Pescado> MixList(List<Camaron> CamaronList, List<Pescado> PescadoList)
        {

            List<Pescado> Lista = new List<Pescado>();
            foreach (Camaron element in CamaronList)
            {
                Pescado pescado = ConvertToPescado(element);
                Lista.Add(pescado);
            }
            foreach (Pescado element in PescadoList)
            {
                Lista.Add(element);
            }

            return Lista;
        }

    }
}
