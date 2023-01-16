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
using MarDeCortezDsk.Styles;
using CustomMessageBox;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class ConfiguracionProveedores : UserControl
    {
        public ConfiguracionProveedores(CrearDelegate _crear,EditarDelegate _editar)
        {
            InitializeComponent();
            labelCrear labelCrear = new labelCrear("Crear nuevo proveedor") { Location = new Point(44, 26) };
            this.Controls.Add(labelCrear);
            this.Crear += new CrearDelegate(_crear);
            this.Editar += new EditarDelegate(_editar);
            labelCrear.Crear += new labelCrear.CrearDelegate(Crear);

        }

        public delegate void GetProveedorDelegate(Proveedor proveedor);
        public event GetProveedorDelegate GetProveedor;


        public delegate void CrearDelegate();
        public event CrearDelegate Crear;

        public delegate void EditarDelegate(Proveedor proveedor);
        public event EditarDelegate Editar;


        ProveedoresControllers proveedorController = new ProveedoresControllers();

        private void DatagridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DatagridProveedor.CurrentRow.Selected = true;
            if (DatagridProveedor.RowCount > 0)
            {
                if (DatagridProveedor.Columns[e.ColumnIndex].Name == "editar")
                {
                    Proveedor proveedor = proveedorController.Get(Convert.ToString(DatagridProveedor.CurrentRow.Cells[0].Value));
                    Editar(proveedor);
                }
                else if (DatagridProveedor.Columns[e.ColumnIndex].Name == "borrar")
                {
                    var dialogBoxOption = RJMessageBox.Show("¿Desea Eliminar este folio?", "Advertencia una vez eliminado no podra recuperarse", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogBoxOption == DialogResult.OK)
                    {
                        proveedorController.Delete(DatagridProveedor.CurrentRow.Cells[0].Value.ToString());
                        DatagridProveedor.Rows.Remove(DatagridProveedor.CurrentRow);
                    }
                }
            }
        }
        

        private void CofiguariosUsuarios_Load(object sender, EventArgs e)
        {




        }


        private void BotonesEdicion_Load(object sender, EventArgs e)
        {

        }

        private void ConfiguracionProveedores_Load(object sender, EventArgs e)
        {
            List<Proveedor> listaProveedor = proveedorController.Get();
            int index;
            foreach (Proveedor element in listaProveedor)
            {
                index = DatagridProveedor.RowCount;
                DatagridProveedor.Rows.Insert(index, element.id_proveedor, element.nombre_proveedor, element.telefono_proveedor);
            }

        }
    }
}
