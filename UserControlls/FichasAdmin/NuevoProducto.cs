using CustomMessageBox;
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
using Org.BouncyCastle.Asn1.Crmf;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class NuevoProducto : UserControl
    {
        public NuevoProducto()
        {
            InitializeComponent();

        }
        private string TipoProducto { get; set; }
  

        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            TxtBoxNombre.Texts = "";
            CmboxTipo.Text = "";

        }

        public delegate void backDelegate();
        public event backDelegate back;
        
        public void Clear()
        {
            TxtBoxNombre.Texts = "";
            CmboxTipo.Text = "";
            RdBtnEmpaquetado.Visible = false;
            RdBtnEntero.Visible = false;
            lblPresentacion.Visible = false;
            LinePresentacion.Visible = false;
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

           if (TxtBoxNombre.Texts != "" && CmboxTipo.Text != "")
           {
                PostProducto(TipoProducto);
                DialogResult result = RJMessageBox.Show("Producto añadido con exito.",
                            "Aviso!");
                back();

            }

           else
           {
             DialogResult result = RJMessageBox.Show("Por favor Complete todos los Campos.",
                            "Aviso!");
           }
          
        }

        public void PostProducto(string name)
        {
            CatalogoProductoController productoController = new CatalogoProductoController();
            Catalogo_Productos producto = new Catalogo_Productos() { tipo_producto = TxtBoxNombre.Texts };
            productoController.Post(producto,name);

        }



        private void CmboxTipo_TextChanged(object sender, EventArgs e)
        {
            if (CmboxTipo.Text == "Otros")
            {
                RdBtnEmpaquetado.Visible = false;
                RdBtnEntero.Visible = false;
                lblPresentacion.Visible = false;
                LinePresentacion.Visible = false;
                TipoProducto = "otros";

            }
            else if (CmboxTipo.Text == "Pescado")
            {
                RdBtnEmpaquetado.Visible = true;
                RdBtnEntero.Visible = true;
                lblPresentacion.Visible = true;
                LinePresentacion.Visible = true;
            }
        }

        private void RdBtnEmpaquetado_CheckedChanged(object sender, EventArgs e)
        {
            TipoProducto = "pescadoEmpaquetado";
        }

        private void RdBtnEntero_CheckedChanged(object sender, EventArgs e)
        {
            TipoProducto = "pescadoEntero";

        }
        private void NuevoUsuario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBoxId__TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            back();
        }
    }
}