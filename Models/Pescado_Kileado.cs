using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    public class Pescado_Kileado
    {
        int id_produto_maquilado { get; set; }
        string tipo_producto { get; set; }
        float kilos { get; set; }
        string almacenaje { get; set; }
        int Id_presentacion { get; set; }
        int id_producto { get; set; }
    }
}