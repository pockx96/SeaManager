using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;
using CustomMessageBox;
using MarDeCortezDsk.UserControlls.Fichas;

namespace MarDeCortezDsk.UserControlls
{
    public partial class PescadoFicha : UserControl
    {
        public PescadoFicha()
        {
            InitializeComponent();
            RbtnEntero.Checked = true;


        }

        private void PescadoFicha_Load(object sender, EventArgs e)
        {

        }

        public string TipoPescado { get; set; }
        public string NombreProducto { get; set; }
        public string ProductoPescado { get; set; }
        public string PresentacionPescado { get; set; }
        public int CantidadPescado { get; set; }


        List<Pescado> ListPescado = new List<Pescado>();
        Pescado pescado = new Pescado();
        CatalogoProductoController productoController = new CatalogoProductoController();
        CatalogoPresentacionController presentacionController = new CatalogoPresentacionController();

        /// <summary>
        /// 
        /// CARGA DE DATOS
        /// 
        /// </summary>

        public void LoadProducto(List<Catalogo_Productos> ListProducto)
        {

           foreach (Catalogo_Productos Pescado in ListProducto)
           {

                CmBoxProducto.Items.Add(Pescado.tipo_producto);

           }

        }
            
  
        public void LoadPresentacion(List<Catalogo_Presentaciones> ListPresentacion)
        {

            foreach (Catalogo_Presentaciones Presentacion in ListPresentacion)
            {

                CmBoxPresentacion.Items.Add(Presentacion.presentaciones);

            }

        }
      



        /// <summary>
        /// 
        /// OBTENER DATOS
        /// 
        /// </summary>
 


        public Pescado GetProducto(string folio,string almacenaje)
        {

            PescadoController controller = new PescadoController();
            pescado.IdProducto = controller.NewId();
            pescado.FolioEntrada = folio;
            pescado.Tipo_producto = CmBoxProducto.Text;
            pescado.Presentacion = CmBoxPresentacion.Text;
            pescado.Almacenaje = almacenaje;
            pescado.Cantidad = Convert.ToInt32(TxtboxCantidad.Text);
            pescado.Kilos = KilosCalculation(pescado.Cantidad,pescado.Presentacion);
            ListPescado.Add(pescado);
            return pescado;

        }

        public bool ValidationForm()
        {
            if (CmBoxPresentacion.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione una presentación.", "Aviso!");
                return false;

            }
            else if (CmBoxProducto.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione un producto.", "Aviso!");
                return false;
            }
            else if (TxtboxCantidad.Value<=0)
            {
                DialogResult result = RJMessageBox.Show("Por favor ingrese una cantidad.", "Aviso!");
                return false;
            }
            return true;
        }



        public void Clear()
        {
            CmBoxProducto.Text = null;
            CmBoxPresentacion.Text = null;
            TxtboxCantidad.Value = 0;
        }

        public float KilosCalculation(int cantidad, string presentacion)
        {
            float kilos;
            switch (presentacion)
            {
                case "kileado":
                    kilos = cantidad;
                    return kilos;
                case "dos kilos":
                    kilos = cantidad * 2;
                    return kilos;
                case "cinco kilos":
                    kilos = cantidad * 5;
                    return kilos;
                case "diez kilos":
                    kilos = cantidad * 10;
                    return kilos;
                case "al vacio":
                    kilos = cantidad;
                    return kilos;
                case "para disco":
                    kilos = cantidad;
                    return kilos;



                case "de 100 a 500 gramos":
                    kilos = cantidad * .35f;
                    return kilos;
                case "de 800 a 1.2 kilos":
                    kilos = cantidad * .75f;
                    return kilos;
                case "de 1.2 a 1.5 kilos":
                    kilos = cantidad;
                    return kilos;
                case "de 1.5 a 2 kilos":
                    kilos = cantidad * 1.8f;
                    return kilos;
                case "de 3 a 4 kilos":
                    kilos = cantidad * 3.5f;
                    return kilos;
                case "5 kilos":
                    kilos = cantidad * 5;
                    return kilos;
                case "6 kilos":
                    kilos = cantidad * 6;
                    return kilos;
                case "7 kilos":
                    kilos = cantidad * 7;
                    return kilos;
                case "8 kilos":
                    kilos = cantidad * 8;
                    return kilos;
                case "9 kilos":
                    kilos = cantidad * 9;
                    return kilos;
                case "10 kilos":
                    kilos = cantidad * 10;
                    return kilos;
                case "11 kilos":
                    kilos = cantidad * 11;
                    return kilos;



            }
            return 0;
        }

            /// <summary>
            /// 
            /// Radio buttons
            /// 
            /// </summary>

            private void RbtnEntero_CheckedChanged(object sender, EventArgs e)
        {
            CmBoxProducto.Items.Clear();
            CmBoxPresentacion.Items.Clear();
            List<Catalogo_Productos> ListProductos = productoController.GetByPescadoEntero();
            List<Catalogo_Presentaciones> ListPresntacion = presentacionController.GetByPescadoEntero();
            LoadProducto(ListProductos);
            LoadPresentacion(ListPresntacion);

        }


        private void RBtnEmpaquetado_CheckedChanged(object sender, EventArgs e)
        {
            CmBoxProducto.Items.Clear();
            CmBoxPresentacion.Items.Clear();
            List<Catalogo_Productos> ListProductos = productoController.GetByPescadoEmpaquetado();
            List<Catalogo_Presentaciones> ListPresntacion = presentacionController.GetByPescadoEmpaquetado();
            LoadProducto(ListProductos);
            LoadPresentacion(ListPresntacion);

        }












        /// <summary>
        /// TRASH
        /// </summary>
        /// 

        private void PescadoContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatosGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblProducto_Click(object sender, EventArgs e)
        {

        }

        private void CmBoxPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
       



    }
}
