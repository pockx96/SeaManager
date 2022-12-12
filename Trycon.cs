using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk
{
    public class Trycon
    {

        
        private string connectionString = "Data Source = DESKTOP-SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true; "; 

      
      

            public void tryconection()
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    
                    connection.Open();
                    MessageBox.Show("Coneccion Exitosa");

            }
                catch
                {
                   MessageBox.Show("Coneccion fallida");


                }
                


            }

            
          
    }
}
