using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.UserControlls
{
    public partial class OtrosFicha : UserControl
    {
        public OtrosFicha()
        {
            InitializeComponent();
        }
        string ProductoPescado { get; set; }
        string PresentacionPescado { get; set; }
        int CantidadPescado { get; set; }

        
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

        private bool DatosChequed()
        {

            if (ProductoChequed() && CantidadChequed() && PresentacionChequed())
            {
                MessageBox.Show(ProductoPescado);
                MessageBox.Show(PresentacionPescado);
                MessageBox.Show(Convert.ToString(CantidadPescado));
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
    }
}
