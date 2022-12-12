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
using MarDeCortezDsk.Styles;
using FontAwesome.Sharp;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.UserControlls.FichasAdmin;


namespace MarDeCortezDsk.UserControlls
{
    public partial class ProductosConfig : UserControl
    {
        public ProductosConfig()
        {
            InitializeComponent();
        }
        NuevoProducto nuevoProducto = new NuevoProducto() { Location = new Point(32, 76) };

        private void ListaFolios_Load(object sender, EventArgs e)
        {
            nuevoProducto.back += new NuevoProducto.backDelegate(back);
            LblOtros.ForeColor = Color.White;
            LblPescados.ForeColor = Color.FromArgb(150, 150, 150);
            CatalogoProductoController productoController = new CatalogoProductoController();
            List<Catalogo_Productos> list = productoController.GetByPescado();
            LoadData(list);
        }


        public void LoadData(List<Catalogo_Productos> list)
        {
          
            DatagridFolios.Rows.Clear();
            int index;
            foreach (Catalogo_Productos element in list)
            {
                index = DatagridFolios.RowCount;
                DatagridFolios.Rows.Insert(index, element.id_producto,element.tipo_producto);
            }
        }


   
        private void DatagridFolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public string GetProvedor()
        {
            return DatagridFolios.CurrentRow.Cells[0].Value.ToString().Replace(" ", String.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LblOtros.ForeColor = Color.White;
            LblPescados.ForeColor = Color.FromArgb(150, 150, 150);
            CatalogoProductoController productoController = new CatalogoProductoController();
            List<Catalogo_Productos> list = productoController.GetByPescado();
            LoadData(list);

        }

        private void LblFinalizados_Click(object sender, EventArgs e)
        {
            LblOtros.ForeColor = Color.FromArgb(150, 150, 150);
            LblPescados.ForeColor = Color.White;
            CatalogoProductoController productoController = new CatalogoProductoController();
            List<Catalogo_Productos> list = productoController.GetByOtros();
            LoadData(list);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblCrear_Click(object sender, EventArgs e)
        {          
            this.Controls.Add(nuevoProducto);
            DatagridFolios.Hide();
            LblCrear.Hide();
            LblPescados.Enabled = false;
            LblOtros.Enabled = false;
        }

        public void back()
        {
            DatagridFolios.Show();
            LblCrear.Show();
            LblOtros.Enabled = true;
            LblPescados.Enabled = true;
            this.Controls.Remove(nuevoProducto);
        }
    }
}
