﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarDeCortezDsk.Models;

namespace MarDeCortezDsk.Models
{
    public class Camaron
    {
        public string IdProducto { get; set; }
        public string FolioEntrada { get; set; }
        public string Tipo_producto { get; set; }
        public float Kilos { get; set; }
        public string Almacenaje { get; set; }
        public string Presentacion { get; set; }
        public int Cantidad { get; set; }
        public string Medida { get; set; }
    }
}