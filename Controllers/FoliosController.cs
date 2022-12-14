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
    public class FoliosController : Controller
    {

        public List<Folios> Get()
        {
            List<Folios> FichaList = new List<Folios>();
            string query = "select * from folios";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Folios Ficha = new Folios();
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.fecha_entrada = reader.GetString(3);
                        FichaList.Add(Ficha);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return FichaList;

            }

        }
        public Folios Get(string folio)
        {
            List<Folios> FichaList = new List<Folios>();
            string query = $"select * from folios where IdFolio = '{folio}' ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                Folios Ficha = new Folios();
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.Estado = reader.GetString(4);
                        Ficha.fecha_entrada = reader.GetString(3);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return Ficha;

            }

        }
        public List<Folios> GetByUser(string user)
        {
            List<Folios> FichaList = new List<Folios>();
            string query = "select * from folios where IdUsuario = '"+ user + "' ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Folios Ficha = new Folios();
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.fecha_entrada = reader.GetString(3);
                        Ficha.Estado = reader.GetString(4);
                        FichaList.Add(Ficha);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return FichaList;

            }

        }


        public List<Folios> GetByProveedor(string proveedor)
        {
            List<Folios> FichaList = new List<Folios>();
            string query = "select * from folios where IdProveedor = '" + proveedor + "' ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Folios Ficha = new Folios();
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.fecha_entrada = reader.GetString(3);
                        Ficha.Estado = reader.GetString(4);
                        FichaList.Add(Ficha);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return FichaList;

            }

        }

        public List<Folios> GetByEstado(string estado,string usuario)
        {
            string Estado = estado;
            string Usuario = usuario;
            List<Folios> FichaList = new List<Folios>();
            string query = $"select * from folios where Estado = '{Estado}' and IdUsuario = '{Usuario}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Folios Ficha = new Folios();
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.fecha_entrada = reader.GetString(3);
                        FichaList.Add(Ficha);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return FichaList;

            }

        }

        public List<Folios> GetByEstado(string estado)
        {
            string Estado = estado;
            List<Folios> FichaList = new List<Folios>();
            string query = $"select * from folios where Estado = '{Estado}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Folios Ficha = new Folios();
                        Ficha.IdFolio = reader.GetString(0);
                        Ficha.id_usuario = reader.GetString(1);
                        Ficha.id_proveedor = reader.GetString(2);
                        Ficha.fecha_entrada = reader.GetString(3);
                        FichaList.Add(Ficha);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return FichaList;

            }

        }


        public void Post(Folios FolioEntrada)
        {

            string queryPost = $"set @Contador = (SELECT COUNT(*) FROM folios); insert into folios values (CONCAT('F-', LPAD( (@Contador+1), 3, '0')),'{FolioEntrada.id_usuario}','{FolioEntrada.id_proveedor}','{FolioEntrada.fecha_entrada}','Pendiente')";
            string queryBitacora = $"set @Contador = (SELECT COUNT(*) FROM Bitacora);INSERT INTO Bitacora VALUES (CONCAT('B-', LPAD( (@Contador+1), 3, '0')), 'Entrada', now(),'{FolioEntrada.id_usuario}','{FolioEntrada.id_proveedor}')";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(queryPost, connection);
                MySqlCommand command2 = new MySqlCommand(queryBitacora, connection);


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
        public void Update(Folios folio)
        {
            string query = $"UPDATE folios set Estado='{folio.Estado}' where IdFolio = '{folio.IdFolio}'";
            string queryBitacora = $"set @Contador = (SELECT COUNT(*) FROM Bitacora);INSERT INTO Bitacora VALUES (CONCAT('B-', LPAD( (@Contador+1), 3, '0')), 'Confirmacion', now(),'{folio.id_usuario}','{folio.id_proveedor}')";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlCommand command2 = new MySqlCommand(queryBitacora, connection);
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
        public string NewId()
        {
            FoliosController fichaServer = new FoliosController();
            List<Folios> fichaList = fichaServer.Get();
            string indexString = Convert.ToString(fichaList.Count + 1);
            return indexString;
           
        }

        public void Delete(string ficha)
        {
            string query = "delete from folios where IdFolio = @ficha";

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

    }
}
