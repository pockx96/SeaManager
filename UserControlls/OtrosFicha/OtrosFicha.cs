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

namespace MarDeCortezDsk.UserControlls
{
    public partial class OtrosFicha : UserControl
    {
        public OtrosFicha()
        {
            InitializeComponent();
        }

        public string TipoPescado { get; set; }
        public string NombreProducto { get; set; }
        public string ProductoPescado { get; set; }
        public string PresentacionPescado { get; set; }
        public int CantidadPescado { get; set; }

        List<Pescado> ListPescado = new List<Pescado>();
        Pescado pescado = new Pescado();

        /// <summary>
        /// OBTENER DATOS
        /// </summary>
        /// 



        public Pescado GetOtrosRow(string FichaEntrada, string Almacenaje)
        {
            pescado.Ficha_Entrada = FichaEntrada;
            pescado.Tipo_producto = NombreProducto;
            pescado.Presentacion = PresentacionPescado;
            pescado.Almacenaje = Almacenaje;
            pescado.Cantidad = CantidadPescado;
            pescado.Kilos = CantidadPescado;
            ListPescado.Add(pescado);
            return pescado;

        }

        public List<Pescado> GetOtrosList()
        {
            return ListPescado;
        }


        private bool NombreChequed()
        {
            if (CmBoxProducto.Text != null)
            {
                NombreProducto = CmBoxProducto.Text;
                return true;
            }

            return false;
        }

        private bool ProductoChequed()
        {
            if (CmBoxProducto.Text!= null)
            {
                ProductoPescado = CmBoxProducto.Text;
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CantidadChequed()
        {

            if (TxtboxCantidad.Text != null)
            {

                try
                {
                    CantidadPescado = Convert.ToInt32(TxtboxCantidad.Text);
                    return true;

                }
                catch
                {
                    MessageBox.Show("Porfavor digita una cantidad / kilos");
                    return false;
                }


            }
            else
            {
                MessageBox.Show("Porfavor digita una cantidad / kilos");
                return false;
            }
        }

        private bool PresentacionChequed()
        {
            if (CmBoxPresentacion.Text != null)
            {
                PresentacionPescado = CmBoxPresentacion.Text;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DatosChequed()
        {

            if (ProductoChequed() && CantidadChequed() && PresentacionChequed() && NombreChequed())
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Conections Oconections = new Conections();

            if (DatosChequed())
            {

                try
                {
                    Oconections.PostfichaTEMP(ProductoPescado, PresentacionPescado, CantidadPescado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de coneccion con la base de datos");
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");

            }


        }

        private void PescadoContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
