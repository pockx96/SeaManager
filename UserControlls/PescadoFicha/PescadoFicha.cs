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

namespace MarDeCortezDsk.UserControlls
{
    public partial class PescadoFicha : UserControl
    {
        public PescadoFicha()
        {
            InitializeComponent();
            RbtnEntero.Checked = true;

        }

        /// <summary>
        /// 
        /// 
        /// Datos Del Formulario
        /// 
        /// 
        /// </summary>

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


          public Pescado GetPescadoRow(string FichaEntrada, string Almacenaje)
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

        public List<Pescado> GetPescadoList()
        {
            return ListPescado;
        }



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
            CmBoxPaquete.Location = new Point(24, 132);
            CmBoxEntero.Hide();
            CmBoxPaquete.Show();

            CmBoxPreEmpaquetado.Location = new Point(24, 208);
            CmBoxPreEntero.Hide();
            CmBoxPreEmpaquetado.Show();
        }

        private void RbtnEntero_CheckedChanged(object sender, EventArgs e)
        {
            CmBoxEntero.Location = new Point(24, 132);
            CmBoxPaquete.Hide();
            CmBoxEntero.Show();

            CmBoxPreEntero.Location = new Point(24, 208);
            CmBoxPreEmpaquetado.Hide();
            CmBoxPreEntero.Show();

        }

        /// <summary>
        /// 
        /// Validadores
        /// 
        /// </summary>
        /// 


        private bool NombreChequed()
        {
            if (CmBoxEntero != null)
            {
                NombreProducto = CmBoxEntero.Text;
                return true;
            }
            else if(CmBoxPaquete != null)
            {
                NombreProducto = CmBoxPaquete.Text;
                return true;
            }
            return false;
        }

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


        public bool DatosChequed()
        {

            if (TipoChequed() && CantidadChequed() && NombreChequed())
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
