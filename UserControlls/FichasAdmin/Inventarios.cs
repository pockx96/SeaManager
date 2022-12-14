using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Styles;
using SpreadsheetLight;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class Inventarios : UserControl
    {
      
        public Inventarios(bool Bitacora)
        {
            InitializeComponent();
            if (Bitacora)
            {
                BtnBitacora.Visible = true;
            }
            else
            {
                BtnBitacora.Visible = false;
            }
        }


        private void Inventarios_Load(object sender, EventArgs e)
        {

            LoadData();
            LoadProveedores();
        }

        public delegate void BitacoraDelegate();
        public event BitacoraDelegate BitacoraEvent;


        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadProveedores()
        {
            ProveedoresControllers proveedoresControllers = new ProveedoresControllers();
            List<Proveedor> ListProveedores = proveedoresControllers.Get();
            foreach (Proveedor proveedor in ListProveedores)
            {
                CmboxProveedor.Items.Add(proveedor.nombre_proveedor);
            }
        }

        public void LoadData()
        {
            PescadoController pescadoController = new PescadoController();
            List<Pescado> pescadoList = pescadoController.GetByProveedor("Tienda");
            CamaronController camaronController = new CamaronController();
            List<Camaron> CamaronList = camaronController.GetByProveedor("Tienda");
            List<Pescado> ListInventario = pescadoController.MixList(CamaronList, pescadoList);
            DatagridInventario.Rows.Clear();
            int index;
            foreach (Pescado element in ListInventario)
            {
                index = DatagridInventario.RowCount;

                DatagridInventario.Rows.Insert(index, element.IdProducto,element.Tipo_producto, element.Presentacion, element.Cantidad, element.Kilos);

            }
        }





        private void DatagridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Animations animations = new Animations();
            Point LocationEliminar = animations.BtnlocationDatagrid(DatagridInventario, 277, Cursor.Position.Y, new Point(463, 96), 12);
            DatagridInventario.CurrentRow.Selected = true;
            
        }



        public void LoadInventarios(List<Inventario> inventarios)
        {
            DatagridInventario.Rows.Clear();
            int index;
            foreach (Inventario element in inventarios)
            {
                index = DatagridInventario.RowCount;
                DatagridInventario.Rows.Insert(index, element.IdInventario,element.Producto, element.Presentacion, element.Cantidad, element.Kilos);

            }
        }




        private void iconButton3_Click(object sender, EventArgs e)
        {
            int ir = 2;
            int cl = 1;
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 10;
            style.Font.Bold = true;
            foreach (DataGridViewColumn column in DatagridInventario.Columns)
            {
                sl.SetCellValue(1, cl, column.HeaderText.ToString());
                sl.SetCellStyle(1, cl, style);
                cl++;

            }

            foreach (DataGridViewRow row in DatagridInventario.Rows)
            {
                sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                ir++;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = String.Format("Inventario" + DateTime.Now.ToString("ddMMyyyyHHmm"));
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Archivo exportado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            BitacoraEvent();
        }
        public delegate void BotonesLateralesDelegate(string proveedor);
        public event BotonesLateralesDelegate BotonesLaterales;
        private void iconButton2_Click_2(object sender, EventArgs e)
        {
            BotonesLaterales(CmboxProveedor.Text);

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventariosController inventariosController = new InventariosController();
            List<Inventario> ListInventarios = inventariosController.Get(CmboxProveedor.Text);
            int index;
            DatagridInventario.Rows.Clear();
            foreach (Inventario inventarios in ListInventarios)
            {
                index = DatagridInventario.Rows.Count;
                DatagridInventario.Rows.Insert(index, inventarios.IdInventario,inventarios.Producto,inventarios.Presentacion,inventarios.Cantidad,inventarios.Kilos);
            }

        }
    }

        
    
}
