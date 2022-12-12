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
    public class CatalogoPresentacionController : Controller
    {
        public List<Catalogo_Presentaciones> Get()
        {

            List<Catalogo_Presentaciones> List = new List<Catalogo_Presentaciones>();
            string query = "select * from catalogopresentacion order by IdPresentacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Presentaciones Presentacion = new Catalogo_Presentaciones();
                        Presentacion.id_presentaciones = reader.GetInt32(0);
                        Presentacion.presentaciones = reader.GetString(1);
                        List.Add(Presentacion);
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

        public Catalogo_Presentaciones Get(string id)
        {

            Catalogo_Presentaciones Presentacion = new Catalogo_Presentaciones();
            string query = $"select * from catalogopresentacion where IdPresentacion = '{id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        Presentacion.id_presentaciones = reader.GetInt32(0);
                        Presentacion.presentaciones = reader.GetString(1);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return Presentacion;

            }
        }
        public List<Catalogo_Presentaciones> GetByPescadoEntero()
        {

            List<Catalogo_Presentaciones> List = new List<Catalogo_Presentaciones>();
            string query = "select * from catalogopresentacion where IdPresentacion between 2100 and 2199 order by IdPresentacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Presentaciones Presentacion = new Catalogo_Presentaciones();
                        Presentacion.id_presentaciones = reader.GetInt32(0);
                        Presentacion.presentaciones = reader.GetString(1);
                        List.Add(Presentacion);
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

        public List<Catalogo_Presentaciones> GetByPescadoEmpaquetado()
        {

            List<Catalogo_Presentaciones> List = new List<Catalogo_Presentaciones>();
            string query = "select * from catalogopresentacion where IdPresentacion between 2200 and 2299 order by IdPresentacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Presentaciones Presentacion = new Catalogo_Presentaciones();
                        Presentacion.id_presentaciones = reader.GetInt32(0);
                        Presentacion.presentaciones = reader.GetString(1);
                        List.Add(Presentacion);
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

        
        public List<Catalogo_Presentaciones> GetByOtros() 
        {

            List<Catalogo_Presentaciones> List = new List<Catalogo_Presentaciones>();
            string query = "select * from catalogopresentacion where IdPresentacion between 3100 and 3299 order by IdPresentacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Catalogo_Presentaciones Presentacion = new Catalogo_Presentaciones();
                        Presentacion.id_presentaciones = reader.GetInt32(0);
                        Presentacion.presentaciones = reader.GetString(1);
                        List.Add(Presentacion);
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



        public void Post(Catalogo_Presentaciones producto ,string tipo)

        {
            int IdPresentacion = NewId(tipo);
            string NombrePresentacion = producto.presentaciones;
            string query = $"insert into catalogopresentacion(IdPresentacion,NombrePresentacion)values('{IdPresentacion}', '{NombrePresentacion}')";

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
            List<Catalogo_Presentaciones> ListPresentacion = new List<Catalogo_Presentaciones>();
            int newId = 0;
            if (tipo == "pescadoEntero")
            {
                ListPresentacion = GetByPescadoEntero();
                int lstLenght = ListPresentacion.Count;
                newId = 100 + lstLenght + 1;
            }
            else if (tipo == "pescadoEmpaquetado")
            {
                ListPresentacion = GetByPescadoEmpaquetado();
                int lstLenght = ListPresentacion.Count;
                newId = 200 + lstLenght + 1;
            }
            else if (tipo == "otros")
            {
                ListPresentacion = GetByOtros();
                int lstLenght = ListPresentacion.Count;
                newId = 300 + lstLenght + 1;
            }
            return newId;

        }

        public void Update(Catalogo_Presentaciones Presentacion)
        {
            int id = Presentacion.id_presentaciones;
            string NombrePresentacion = Presentacion.presentaciones;
            string query = $"update catalogopresentacion set  NombrePresentacion = '{NombrePresentacion}' where IdPresentacion = '{id}'";
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
            string query = $"delete from catalogopresentacion where IdPresentacion = '{id}'";

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
