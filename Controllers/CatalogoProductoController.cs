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
    public class CatalogoProductoController : Controller
    {
        public List<Catalogo_Productos> Get()
        {

            List<Catalogo_Productos> List = new List<Catalogo_Productos>();
            string query = "select * from catalogoproducto order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Productos Productos = new Catalogo_Productos();
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                        List.Add(Productos);
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

        public Catalogo_Productos Get(string id)
        {

            Catalogo_Productos Productos = new Catalogo_Productos();
            string query = "select * from catalogoproducto order by NombreProducto order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return Productos;

            }
        }

 
        public List<Catalogo_Productos> GetByPescadoEntero()
        {

            List<Catalogo_Productos> List = new List<Catalogo_Productos>();
            string query = "select * from catalogoproducto where IdProducto between 2000 and 2199 order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Productos Productos = new Catalogo_Productos();
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                        List.Add(Productos);
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

        public List<Catalogo_Productos> GetByPescadoEmpaquetado()
        {

            List<Catalogo_Productos> List = new List<Catalogo_Productos>();
            string query = "select * from catalogoproducto where IdProducto between 2200 and 2299 order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Productos Productos = new Catalogo_Productos();
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                        List.Add(Productos);
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

        public List<Catalogo_Productos> GetByPescado()
        {

            List<Catalogo_Productos> List = new List<Catalogo_Productos>();
            string query = "select * from catalogoproducto where IdProducto between 2000 and 2299 order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Productos Productos = new Catalogo_Productos();
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                        List.Add(Productos);
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

        public List<Catalogo_Productos> GetByOtros()
        {

            List<Catalogo_Productos> List = new List<Catalogo_Productos>();
            string query = "select * from catalogoproducto where IdProducto between 3000 and 3199 order by NombreProducto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Productos Productos = new Catalogo_Productos();
                        Productos.id_producto = reader.GetInt32(0);
                        Productos.tipo_producto = reader.GetString(1);
                        List.Add(Productos);
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



        public void Post(Catalogo_Productos producto, string tipo)

        {
            int IdProducto = NewId(tipo);
            string NombreProducto = producto.tipo_producto;
            string query = $"insert into catalogoproducto (IdProducto ,NombreProducto) values ({IdProducto},'{NombreProducto}')";

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

        public int NewId(string tipo)
        {
            List<Catalogo_Productos> ListProducto = new List<Catalogo_Productos>();
            int newId = 0;
            if(tipo == "pescadoEntero")
            {
                ListProducto = GetByPescadoEntero();
                int lstLenght = ListProducto.Count;
                newId = 2100 + lstLenght+ 1;
            }
            else if(tipo == "pescadoEmpaquetado")
            {
                ListProducto = GetByPescadoEmpaquetado();
                int lstLenght = ListProducto.Count;
                newId = 2200 + lstLenght + 1;
            }
            else if (tipo == "otros")
            {
                ListProducto = GetByOtros();
                int lstLenght = ListProducto.Count;
                newId = 3100 + lstLenght + 1;
            }
            return newId;

        }

        public void Update(Catalogo_Productos producto)
        {
            int id = producto.id_producto;
            string NombreProducto = producto.tipo_producto;
            string query = $"update catalogoproducto set  NombreProducto = '{NombreProducto}' where IdProducto = {id}";
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
        public void Delete(string id)
        {
            string query = $"delete from catalogoproducto where IdProducto = '{id}'";

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
