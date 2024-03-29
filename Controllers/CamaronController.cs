﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Models;
using System.Data.SqlClient;
using MySqlConnector;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

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
        public void Post(Camaron camaron,string proveedor)
        {

            string query = $"set @idFolio = (SELECT IdFolio FROM folios ORDER BY IdFolio DESC LIMIT 1); set @Contador = (SELECT COUNT(*) FROM camaron);INSERT INTO camaron VALUES (CONCAT('C-', LPAD( (@Contador+1), 3, '0')), @idFolio,'{camaron.Tipo_producto}','{camaron.Kilos}','{camaron.Medida}','{camaron.Almacenaje}','{camaron.Presentacion}','{camaron.Cantidad}')";

            string queryInventarioInsert = $"set @Contador = (SELECT COUNT(*) FROM Inventarios);INSERT INTO Inventarios VALUES (CONCAT('I-', LPAD( (@Contador+1), 3, '0')), '{proveedor}' ,'{camaron.Tipo_producto}' ,'{camaron.Presentacion} {camaron.Medida}','{camaron.Cantidad}','{camaron.Kilos}')";

            string queryInventarioUpdate = $"set @sumaCantidad =(SELECT Cantidad FROM Inventarios where Proveedor = '{proveedor}' and Presentacion = '{camaron.Presentacion} {camaron.Medida}')+{camaron.Cantidad};set @sumaKilos =(SELECT Kilos FROM Inventarios where Proveedor = '{proveedor}' and Presentacion = '{camaron.Presentacion} {camaron.Medida}')+{camaron.Kilos};update Inventarios set Cantidad = @sumaCantidad , Kilos = @sumaKilos where Presentacion = '{camaron.Presentacion} {camaron.Medida}' and Producto = '{camaron.Tipo_producto}' and Proveedor = '{proveedor}'";


            InventariosController inventariosController = new InventariosController();
            List<Inventario> list = inventariosController.Get(proveedor);
            string Presentacion = $"{camaron.Presentacion} {camaron.Medida}";
            string queryInvetario = "";

            queryInvetario = queryInventarioInsert;

            foreach (Inventario element in list)
            {
                if (element.Proveedor == proveedor && element.Presentacion == Presentacion && element.Producto == camaron.Tipo_producto)
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

        public void RestasPost(Camaron camaron, string proveedor)
        {
           string query = $"set @idFolio = (SELECT IdFolio FROM folios ORDER BY IdFolio DESC LIMIT 1); set @Contador = (SELECT COUNT(*) FROM camaron);INSERT INTO camaron VALUES (CONCAT('C-', LPAD( (@Contador+1), 3, '0')), @idFolio,'{camaron.Tipo_producto}','{camaron.Kilos}','{camaron.Medida}','{camaron.Almacenaje}','{camaron.Presentacion}','{camaron.Cantidad}')";


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

        public float KilosCalculation(int cantidad, string presentacion)
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
            return 0;
        }
    }
}
