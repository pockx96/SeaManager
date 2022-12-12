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

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class ConfiguracionProveedores : UserControl
    {
        public ConfiguracionProveedores()
        {
            InitializeComponent();
        }

        public delegate void GetProveedorDelegate(Proveedor proveedor);
        public event GetProveedorDelegate GetProveedor;


        public delegate void CrearDelegate();
        public event CrearDelegate Crear;

        public delegate void DelegateEditar();
        public event DelegateEditar Editar;

        public delegate void DelegateDetalles();
        public event DelegateDetalles Detalles;

        ProveedoresControllers proveedorServise = new ProveedoresControllers();

        private void DatagridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point location = animations.BtnlocationDatagrid(DatagridProveedor,340,Cursor.Position.Y,new Point(475, 117),12);
            BotonesEdicion.Location = location;
            Proveedor proveedor = proveedorServise.Get(DatagridProveedor.CurrentRow.Cells[0].Value.ToString());
            GetProveedor(proveedor);
            DatagridProveedor.CurrentRow.Selected = true;
        }

        private void CofiguariosUsuarios_Load(object sender, EventArgs e)
        {
            labelCrear labelCrear = new labelCrear("Crear nuevo proveedor"){ Location = new Point(44, 26) };
            this.Controls.Add(labelCrear);
            List<Proveedor> listaProveedor = proveedorServise.Get();
            int index;
            foreach (Proveedor element in listaProveedor)
            {
                index = DatagridProveedor.RowCount;
                DatagridProveedor.Rows.Insert(index, element.id_proveedor, element.nombre_proveedor, element.telefono_proveedor);
            }

            if (Editar != null && /*Detalles != null &&*/ Crear != null)
            {

                BotonesEdicion.eliminar += new botonesEdicion.eliminarDelegate(Eliminar);
                BotonesEdicion.editar += new botonesEdicion.editarDelegate(Editar);
                /*BotonesEdicion.detalles += new botonesEdicion.detallerDelegate(Detalles);*/
                labelCrear.Crear += new labelCrear.CrearDelegate(Crear);

            }

            DatagridProveedor.CurrentRow.Selected = true;
        }

        private void Eliminar()
        {
            if (DatagridProveedor.Rows.Count>0)
            {
                proveedorServise.Delete(DatagridProveedor.CurrentRow.Cells[0].Value.ToString());
                DatagridProveedor.Rows.Remove(DatagridProveedor.CurrentRow);

            }
        }
    }
}
