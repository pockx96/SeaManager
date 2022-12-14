using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    public class Inventario
    {
        public string IdInventario { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public string Presentacion { get; set; }
        public int Cantidad { get; set; }
        public float Kilos { get; set; }
    }
}
