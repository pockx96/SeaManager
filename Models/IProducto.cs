using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Models
{
    internal interface IProducto
    {
        string IdProducto { get; set; }
        string FolioEntrada { get; set; }
        string Tipo_producto { get; set; }
        float? Kilos { get; set; }
        string Almacenaje { get; set; }
        string Presentacion { get; set; }
        int Cantidad { get; set; }
    }
}
