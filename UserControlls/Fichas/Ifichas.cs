using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Models;

namespace MarDeCortezDsk.UserControlls.Fichas
{
    internal interface Ifichas
    {
        Pescado GetProducto(string FichaEntrada, string almacenaje);
        bool ValidationValues();
        void Clear();
        void LoadPresentacion(List<Catalogo_Presentaciones> ListPresentacion);
        void LoadProducto(List<Catalogo_Productos> ListProducto);
        float? KilosCalculation(int cantidad, string presentacion);

    }
}
