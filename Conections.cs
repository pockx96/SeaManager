using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk
{
    public class Conections
    {
        public string connectionString = "Data Source = DESKTOP-SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true; ";

       
        public List<Usuarios> GetUsuarios(string id)
        {
            List<Usuarios> usuario = new List<Usuarios>();

            string query = "select * from Usuarios where id_usuario = '"+id+"' ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuarios oUsuarios = new Usuarios();
                        oUsuarios.id_usuario = reader.GetString(0);
                        oUsuarios.tipo_usuario = reader.GetString(1);
                        oUsuarios.nombre_usuario = reader.GetString(2);
                        oUsuarios.password = reader.GetString(3);
                        usuario.Add(oUsuarios);

                    }
                    reader.Close();

                }
                catch(Exception ex)
                {
                    throw new Exception("error de la base de datos : "+ex);

                }

                return usuario;

            }
        }


        public List<Proveedor> GetProveedores()
        {
            List<Proveedor> proveedors = new List<Proveedor>();
            string query = "select nombre_proveedor from Proveedor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Proveedor oproveedor = new Proveedor();
                        oproveedor.nombre_proveedor = reader.GetString(0);
                        proveedors.Add(oproveedor);

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return proveedors;

            }
        }

        public List<fichaTEMP> GetFichasTemp()
        {
            List<fichaTEMP> ficha = new List<fichaTEMP>();
            string query = "select Nombre,Tipo,Cantidad from fichaTEMP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        fichaTEMP oficha = new fichaTEMP();
                        oficha.Nombre = reader.GetString(0);
                        oficha.Tipo = reader.GetString(1);
                        oficha.Cantidad = reader.GetInt32(2);
                        ficha.Add(oficha);

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return ficha;

            }
        }


        public List<Ficha> GetFichas()
        {
            List<Ficha> ficha = new List<Ficha>();
            string query = "select * from Ficha";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Ficha oficha = new Ficha();
                        oficha.Nombre = reader.GetString(0);
                        oficha.Tipo = reader.GetString(1);
                        oficha.Cantidad = reader.GetInt32(2);
                        oficha.fecha = reader.GetString(3);


                        ficha.Add(oficha);

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return ficha;

            }
        }

        public void PostProveedores(string Idproveedor ,string NombreProv,string TelefonoProv)
        {
            string query = "insert into Proveedor(id_proveedor, nombre_proveedor, telefono_proveedor) values"+ "(@Idproveedor, @NombreProv, @TelefonoProv)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Idproveedor", Idproveedor);
                command.Parameters.AddWithValue("@NombreProv", NombreProv);
                command.Parameters.AddWithValue("@TelefonoProv", TelefonoProv);

                try
                {
                    connection.Open();
                  command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }       
            }
        }
        public void PostfichaTEMP(string Nombre, string Tipo, int Cantidad)
        {
            string query = "insert into fichaTEMP(Nombre, Tipo, Cantidad) values" + "(@nombre, @tipo, @cantidad)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@tipo", Tipo);
                command.Parameters.AddWithValue("@cantidad", Cantidad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }
            }
        }

        public void Postficha(string Nombre, string Tipo, int Cantidad,string fecha)
        {
            string query = "insert into ficha(Nombre, Tipo, Cantidad,fecha) values" + "(@nombre, @tipo, @Cantidad,@fecha)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.Parameters.AddWithValue("@Cantidad", Cantidad);
                command.Parameters.AddWithValue("@fecha", fecha);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }
            }
        }

        public void DeletefichaTEMP()
        {
            string query = "TRUNCATE table fichaTEMP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }
            }
        }




    }
}
