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
using CustomMessageBox;
using MarDeCortezDsk.UserControlls.Fichas;

namespace MarDeCortezDsk.UserControlls
{
    public partial class OtrosFicha : UserControl 
    {
 
        
        public OtrosFicha()
        {
            InitializeComponent();
        }
        public OtrosFicha(Pescado pescado)
        {
            this.pescado = pescado;
        }

        private void OtrosFicha_Load(object sender, EventArgs e)
        {
            List<Catalogo_Productos> ListProducto = productoController.GetByOtros();
            List<Catalogo_Presentaciones> ListPresentacion = presentacionController.GetByOtros();
            LoadProducto(ListProducto);
            LoadPresentacion(ListPresentacion);
        }


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



        public Pescado GetProducto(string FichaEntrada, string almacenaje)
        {

            PescadoController controller = new PescadoController();
            pescado.IdProducto = controller.NewId();
            pescado.FolioEntrada = FichaEntrada;
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
            if (CmBoxProducto.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione un producto.", "Aviso!");
                return false;
            }
            else if (CmBoxPresentacion.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione una presentación.", "Aviso!");
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


        public float KilosCalculation(int cantidad , string presentacion) 
        {
            float kilos;
            switch (presentacion)
            {

                case "suelto":
                    kilos = cantidad;
                    return kilos;
                case "kilo":
                    kilos = cantidad * 1;
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

            }

            return 0;
        }






        /// <summary>
        /// TRASH
        /// </summary>

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
        }
        private void PescadoContainer_Paint(object sender, PaintEventArgs e)
        {
        }
        private void CmBoxPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       
    }
}
