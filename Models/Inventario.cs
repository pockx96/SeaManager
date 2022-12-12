using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    public class Inventario
    {
        public string Id_producto { get; set; }
        public string Producto { get; set; }
        public string Presentacion { get; set; }
        public int Stock { get; set; }
        public int Kilos { get; set; }
    }
}
