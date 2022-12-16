using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Models;
using System.Data.SqlClient;
using MySqlConnector;
using DocumentFormat.OpenXml.Drawing;

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

        
        public void Post(Pescado pescado,string proveedor)
        {

            string query = $"set @idFolio = (SELECT IdFolio FROM folios ORDER BY IdFolio DESC LIMIT 1); set @Contador = (SELECT COUNT(*) FROM pescado);INSERT INTO pescado VALUES (CONCAT('P-', LPAD( (@Contador+1), 3, '0')), @idFolio,'{pescado.Tipo_producto}','{pescado.Almacenaje}','{pescado.Presentacion}','{pescado.Kilos}','{pescado.Cantidad}')";

            string queryInventarioInsert = $"set @Contador = (SELECT COUNT(*) FROM Inventarios);INSERT INTO Inventarios VALUES (CONCAT('I-', LPAD( (@Contador+1), 3, '0')), '{proveedor}' ,'{pescado.Tipo_producto}' ,'{pescado.Presentacion}','{pescado.Cantidad}','{pescado.Kilos}')";

            string queryInventarioUpdate = $"set @sumaCantidad =(SELECT SUM(Cantidad) AS TotalItemsOrdered FROM pescado where Almacenaje = '{proveedor}' and Presentacion = '{pescado.Presentacion}');set @sumaKilos =(SELECT SUM(Kilos) AS TotalItemsOrdered FROM pescado where Almacenaje = '{proveedor}' and Presentacion = '{pescado.Presentacion}');update Inventarios set Cantidad = @sumaCantidad , Kilos = @sumaKilos where Presentacion = '{pescado.Presentacion}' and Producto = '{pescado.Tipo_producto}' and Proveedor = '{proveedor}'";


            InventariosController inventariosController = new InventariosController();
            List<Inventario> list = inventariosController.Get(proveedor);
            string queryInvetario = "";

            queryInvetario = queryInventarioInsert;

            foreach (Inventario element in list)
            {
                if (element.Proveedor == proveedor && element.Presentacion == pescado.Presentacion && element.Producto == pescado.Tipo_producto)
                {

                    queryInvetario = queryInventarioUpdate;

                }

            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlCommand command2 = new MySqlCommand(queryInvetario, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }
            }
        }


        public void Post(Pescado pescado, string proveedor, Inventario inventario)
        {
            string query = $"set @idFolio = (SELECT IdFolio FROM folios ORDER BY IdFolio DESC LIMIT 1); set @Contador = (SELECT COUNT(*) FROM pescado);INSERT INTO pescado VALUES (CONCAT('P-', LPAD( (@Contador+1), 3, '0')), @idFolio,'{pescado.Tipo_producto}','{pescado.Almacenaje}','{pescado.Presentacion}','{pescado.Kilos}','{pescado.Cantidad}')";
            string queryInventarioInsert = $"set @Contador = (SELECT COUNT(*) FROM Inventarios);set @proveedor = (SELECT Almacenaje FROM camaron ORDER BY IdProducto DESC LIMIT 1);set @sumaCantidad =(SELECT SUM(Cantidad) AS TotalItemsOrdered FROM camaron where Almacenaje = @proveedor);set @sumaKilos =(SELECT SUM(Kilos) AS TotalItemsOrdered FROM camaron where Almacenaje = @proveedor);INSERT INTO Inventarios VALUES (CONCAT('I-', LPAD( (@Contador+1), 3, '0')), @proveedor ,'{pescado.Tipo_producto}' ,'{pescado.Presentacion}',@sumaCantidad,@sumaKilos)";

            string queryInventarioUpdate = $"set @proveedor = (SELECT Almacenaje FROM camaron ORDER BY IdProducto DESC LIMIT 1);set @sumaCantidad =(SELECT SUM(Cantidad) AS TotalItemsOrdered FROM camaron where Almacenaje = @proveedor);set @sumaKilos =(SELECT SUM(Kilos) AS TotalItemsOrdered FROM camaron where Almacenaje = @proveedor);update Inventarios set Cantidad = @sumaCantidad , Kilos = @sumaKilos where Presentacion = '{pescado.Presentacion}' and Producto = '{pescado.Tipo_producto}' and Proveedor = @proveedor";


            InventariosController inventariosController = new InventariosController();
            List<Inventario> list = inventariosController.Get(proveedor);
            string queryInvetario = "";
            foreach (Inventario element in list)
            {
                if (element.Proveedor == proveedor && element.Presentacion == pescado.Presentacion)
                {

                    queryInvetario = queryInventarioUpdate;

                }
                else
                {
                    queryInvetario = queryInventarioInsert;
                }

            }
            if (list.Count == 0)
            {
                queryInvetario = queryInventarioInsert;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlCommand command2 = new MySqlCommand(queryInvetario, connection);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
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
