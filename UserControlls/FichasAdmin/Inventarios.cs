using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        InventariosController inventariosController = new InventariosController();
        private void Inventarios_Load(object sender, EventArgs e)
        {

            List<Inventario> ListInventarios = inventariosController.Get("Tienda");
            LoadInventarios(ListInventarios);
            LoadProveedoreCmBox();
            CmboxProveedor.Text = "Tienda";
        }

        public delegate void BitacoraDelegate();
        public event BitacoraDelegate BitacoraEvent;


        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }







        private void DatagridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            
        }



        public void LoadInventarios(List<Inventario> inventarios)
        {
            DatagridInventario.SuspendLayout();
            DatagridInventario.Rows.Clear();
            int index;
            var lstSort = inventarios.Where(f => f.Cantidad > 0);
            foreach (Inventario element in lstSort)
            {
                index = DatagridInventario.RowCount;
                DatagridInventario.Rows.Insert(index, element.IdInventario,element.Producto, element.Presentacion, element.Cantidad, element.Kilos);

            }
            DatagridInventario.ResumeLayout();
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
            List<Inventario> ListInventarios = inventariosController.Get(CmboxProveedor.Text);
            DatagridInventario.Rows.Clear();
            LoadInventarios(ListInventarios);

        }


        bool flagCmBox = false ;
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (flagCmBox)
            {
                CmboxProveedor.Visible = false;
                LblProveedor.Visible = false;
                BtnSearch.Location = new Point(458, 23);
                flagCmBox = false;
            }
            else
            {
                LblProveedor.Visible = true;
                CmboxProveedor.Visible = true;
                BtnSearch.Location = new Point(612, 26);
                flagCmBox = true;

            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            
            List<Inventario> ListInventarios = inventariosController.Get("Tienda");
            CmboxProveedor.Text = "Tienda";
            LoadInventarios(ListInventarios);
        }
        


        private void TxtBoxSearch__TextChanged(object sender, EventArgs e)
        {
            List<Inventario> Listinventarios = inventariosController.Get(CmboxProveedor.Text);
            var lst = Listinventarios.Where(f => f.Producto.Contains(TxtBoxSearch.Texts)).ToList();
            LoadInventarios(lst);

        }

        private void LoadProveedoreCmBox()
        {
            ProveedoresControllers proveedoresControllers = new ProveedoresControllers();
            List<Proveedor> proveedors = proveedoresControllers.Get();
            foreach(Proveedor proveedor in proveedors)
            {
                CmboxProveedor.Items.Add(proveedor.nombre_proveedor);
            }

        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnTienda_MouseHover(object sender, EventArgs e)
        {
        }

        private void BtnSalidas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnSalidas_MouseEnter(object sender, EventArgs e)
        {


        }
    }

        
    
}
