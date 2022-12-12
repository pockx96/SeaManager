using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;

namespace MarDeCortezDsk.UserControlls.Fichas
{
    public partial class FichaConficion : UserControl
    {
        public FichaConficion(string ficha)
        {
            InitializeComponent();
            fichaEntradas = ficha;
        }

        private void FichaConficion_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            ListaEntrada.Rows.Clear();
        }
        public string fichaEntradas { get; set; }

        public void LoadData()
        {
            FichaEntradaController FichasServise = new FichaEntradaController();
            CamaronController CamaronServise = new CamaronController();
            PescadoController PescadoServise = new PescadoController();


            List<Pescado> ListPescados = PescadoServise.Get(fichaEntradas);
            List<Camaron> ListCamarones = CamaronServise.Get(fichaEntradas);

            int index;
            foreach (Pescado element in ListPescados)
            {
                index = ListaEntrada.RowCount;
                ListaEntrada.Rows.Insert(index, element.Tipo_producto, element.Presentacion, element.Cantidad, element.Kilos);
            }
            foreach (Camaron element in ListCamarones)
            {
                string PresentacionCamaron = element.Presentacion + " " + element.Medida;
                index = ListaEntrada.RowCount;
                ListaEntrada.Rows.Insert(index, element.Tipo_producto, PresentacionCamaron, element.Cantidad, element.kilos);
            }

        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
