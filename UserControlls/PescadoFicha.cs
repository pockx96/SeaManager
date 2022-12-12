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
    public partial class PescadoFicha : UserControl
    {
        public PescadoFicha()
        {
            InitializeComponent();
            CmBoxEntero.Hide();
            RBtnEmpaquetado.Checked = true;
            CantidadPescado = 0;

        }

        /// <summary>
        /// 
        /// Datos Del Formulario
        /// 
        /// </summary>

        string TipoPescado { get; set; }
        string ProductoPescado { get; set; }
        string PresentacionPescado { get; set; }
        int CantidadPescado { get; set; }




        private void PescadoContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatosGroupBox_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        ///   RADIO BUTONS
        ///   
        /// </summary>

        private void RBtnEmpaquetado_CheckedChanged(object sender, EventArgs e)
        {
            CmBoxEntero.Hide();
            CmBoxPaquete.Show();
            CmBoxPreEntero.Hide();
            CmBoxPreEmpaquetado.Show();
        }

        private void RbtnEntero_CheckedChanged(object sender, EventArgs e)
        {
            CmBoxEntero.Location = new Point(121, 87);
            CmBoxPaquete.Hide();
            CmBoxEntero.Show();
            CmBoxPreEntero.Location = new Point(121, 148);
            CmBoxPreEmpaquetado.Hide();
            CmBoxPreEntero.Show();

        }

        /// <summary>
        /// 
        /// Validadores
        /// 
        /// </summary>
        /// 


        private bool TipoChequed()
        {
            if (RBtnEmpaquetado.Checked == true)
            {
                ProductoPescado = CmBoxPaquete.Text;
                PresentacionPescado = CmBoxPreEmpaquetado.Text;
                TipoPescado = "Empaquetado";
                return true;
            }
            else if(RbtnEntero.Checked == true)
            {
                ProductoPescado = CmBoxPreEntero.Text;
                PresentacionPescado = CmBoxPreEntero.Text;
                TipoPescado = "Entero";
                return true;
            }
            else
            {
                MessageBox.Show("Rellena Todos los Campos porfavor");
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


        private bool DatosChequed()
        {

            if (TipoChequed() && CantidadChequed())
            {
                MessageBox.Show(TipoPescado);
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
                    Oconections.PostfichaTEMP(ProductoPescado, TipoPescado, CantidadPescado);
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
