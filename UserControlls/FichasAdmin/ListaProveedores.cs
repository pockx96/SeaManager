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
using MarDeCortezDsk.UserControlls;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class ListaProveedores : UserControl
    {
        public ListaProveedores()
        {
            InitializeComponent();
        }

        private void DatagridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            ProveedoresControllers ProveedorServise = new ProveedoresControllers();
            LoadData(ProveedorServise.Get());
        }

        public void LoadData(List<Proveedor> listaProveedores)
        {
            ProveedoresControllers ProvedorServise = new ProveedoresControllers();
            int index;
            foreach (Proveedor element in listaProveedores)
            {
                index = DatagridUsuarios.RowCount;
                DatagridUsuarios.Rows.Insert(index, element.id_proveedor, element.nombre_proveedor, element.telefono_proveedor);

            }
        }
    }
}
