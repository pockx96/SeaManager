using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    public class Camaron_marquetado
    {
        int id_producto_maquilado { get; set; }
        string tipo_producto { get; set; }
        int kilos { get; set; }
        int id_medida { get; set; }
        string almacenaje { get; set; }
        int id_presentacion { get; set; }
        int cantidad_marquetas { get; set; }
        int id_producto { get; set; }
    }
}