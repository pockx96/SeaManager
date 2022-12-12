using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Controllers
{
    public class Controller
    {
        public string connectionString = "Server=bqmdgve1fhwl2vjd5wwf-mysql.services.clever-cloud.com;Database=bqmdgve1fhwl2vjd5wwf; Uid=uzpxn5pgrttsxccr;Pwd=JUfLv4iaA9cESXBnmRPH;";
        public string stringToDb(string word)
        {
            int lenght = 50 - word.Length;
            string StringDb = word;
            for (int i = 0; i < lenght; i++)
            {
                StringDb = StringDb + " ";
            }
            return StringDb;
        }
    }
   
}
