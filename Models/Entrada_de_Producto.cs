using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    public class Entrada_de_Producto
    {
        int id_producto_maquilado { get; set; }
        string id_produto { get; set; }
        string id_usuario { get; set; }
        string id_proveedor { get; set; }
        string fecha_entrada { get; set; }
    }
}
