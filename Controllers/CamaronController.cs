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
    internal class CamaronController : Controller 
    {
       
        public List<Camaron> Get()
        {

            List<Camaron> List = new List<Camaron>();
            string query = "select * from camaron order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Camaron camaron = new Camaron();
                        camaron.IdProducto = reader.GetString(0);
                        camaron.FolioEntrada = reader.GetString(1);
                        camaron.Tipo_producto = reader.GetString(2);
                        camaron.Kilos = reader.GetFloat(3);
                        camaron.Medida = reader.GetString(4);
                        camaron.Almacenaje = reader.GetString(5);
                        camaron.Presentacion = reader.GetString(6);
                        camaron.Cantidad = reader.GetInt32(7);
                        List.Add(camaron);

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
        public Camaron Get(string id)
        {
            Camaron camaron = new Camaron();
            string query = "select * from camaron where IdProducto = '" + id + "' order by TipoProducto"; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        camaron.IdProducto = reader.GetString(0);
                        camaron.FolioEntrada = reader.GetString(1);
                        camaron.Tipo_producto = reader.GetString(2);
                        camaron.Kilos = reader.GetFloat(3);
                        camaron.Medida = reader.GetString(4);
                        camaron.Almacenaje = reader.GetString(5);
                        camaron.Presentacion = reader.GetString(6);
                        camaron.Cantidad = reader.GetInt32(7);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return camaron;

            }
        }
        public Camaron Get(Camaron camaronStock)
        {
            Camaron camaron = new Camaron();
            string query = $"select * from camaron where Almacenaje = 'Tienda' and TipoProducto = '{camaronStock.Tipo_producto}' and Presentacion = '{camaronStock.Presentacion}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        camaron.IdProducto = reader.GetString(0);
                        camaron.FolioEntrada = reader.GetString(1);
                        camaron.Tipo_producto = reader.GetString(2);
                        camaron.Kilos = reader.GetFloat(3);
                        camaron.Medida = reader.GetString(4);
                        camaron.Almacenaje = reader.GetString(5);
                        camaron.Presentacion = reader.GetString(6);
                        camaron.Cantidad = reader.GetInt32(7);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return camaron;

            }
        }

        public List<Camaron> GetbyFolio(string id)
        {
            List<Camaron> List = new List<Camaron>();
            string query = "select * from camaron where IdFolio = '" + id + "' order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Camaron camaron = new Camaron();
                        camaron.IdProducto = reader.GetString(0);
                        camaron.FolioEntrada = reader.GetString(1);
                        camaron.Tipo_producto = reader.GetString(2);
                        camaron.Kilos = reader.GetFloat(3);
                        camaron.Medida = reader.GetString(4);
                        camaron.Almacenaje = reader.GetString(5);
                        camaron.Presentacion = reader.GetString(6);
                        camaron.Cantidad = reader.GetInt32(7);
                        List.Add(camaron);

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


        public List<Camaron> GetByProveedor(string almacenaje)
        {
            List<Camaron> List = new List<Camaron>();
            string query = "select * from camaron where Almacenaje = '" + almacenaje + "' order by TipoProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Camaron camaron = new Camaron();
                        camaron.IdProducto = reader.GetString(0);
                        camaron.FolioEntrada = reader.GetString(1);
                        camaron.Tipo_producto = reader.GetString(2);
                        camaron.Kilos = reader.GetFloat(3);
                        camaron.Medida = reader.GetString(4);
                        camaron.Almacenaje = reader.GetString(5);
                        camaron.Presentacion = reader.GetString(6);
                        camaron.Cantidad = reader.GetInt32(7);
                        List.Add(camaron);

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
        public void Post(Camaron camaron)
        
        {
            string idProducto = NewId();
            string ficha = camaron.FolioEntrada;
            string tipo_producto = camaron.Tipo_producto;
            float? Kilos = camaron.Kilos;
            string medida = camaron.Medida;
            string almacenaje = camaron.Almacenaje;
            string presentacion = camaron.Presentacion;
            int cantidad = camaron.Cantidad;
            string query = "insert into camaron(IdProducto, IdFolio, TipoProducto, Kilos, Medida, Almacenaje, Presentacion, Cantidad) values" + "(@idProducto, @FolioEntrada, @tipo_producto, @Kilos, @medida,  @almacenaje, @presentacion, @cantidad)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.Parameters.AddWithValue("@FolioEntrada", ficha);
                command.Parameters.AddWithValue("@tipo_producto", tipo_producto);
                command.Parameters.AddWithValue("@Kilos", Kilos);
                command.Parameters.AddWithValue("@medida", medida);
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

        public string NewId()
        {
            CamaronController camaronController = new CamaronController();
            List<Camaron> fichaList = camaronController.Get();
            int index = fichaList.Count + 1;
            string indexString = Convert.ToString(index);

            if (indexString.Length == 1)
            {
                return "C0" + indexString;
            }
            else if (indexString.Length == 2)
            {
                return "C" + indexString;
            }
            return indexString;


        }

        public void Update(Camaron camaron , bool SumaResta)
        {
            Camaron CamaronStock = Get(camaron);
            float? Kilos;
            int cantidad;
            if (SumaResta)
            {
                Kilos = camaron.Kilos + CamaronStock.Kilos;
                cantidad = camaron.Cantidad + CamaronStock.Cantidad;
            }
            else
            {
                Kilos = CamaronStock.Kilos - camaron.Kilos;
                cantidad =  CamaronStock.Cantidad - camaron.Cantidad;
            }
            

            string query = $"update camaron set Kilos = {Kilos}, Cantidad = {cantidad} where Almacenaje = 'Tienda' and Presentacion = '{camaron.Presentacion}' and Medida = '{camaron.Medida}'";
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
  
        public void Delete(string ficha)
        {

            string query = "delete from camaron where IdProducto = @ficha";
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

        public float? KilosCalculation(int cantidad, string presentacion)
        {
            float kilos;
            switch (presentacion)
            {
                case "Maqueta 2KG":
                    kilos = cantidad * 2;
                    return kilos;
                case "Maqueta 5KG":
                    kilos = cantidad * 5;
                    return kilos;
                case "Al Vacio":
                    kilos = cantidad;
                    return kilos;
                case "Kileado":
                    kilos = cantidad;
                    return kilos;

            }
            return null;
        }
    }
}
