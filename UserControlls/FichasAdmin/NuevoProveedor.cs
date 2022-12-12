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

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class NuevoProveedor : UserControl
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true; ");

        public delegate void CallbackDelegado();
        public event CallbackDelegado callback;
        private void botonRedondo1_Click(object sender, EventArgs e)
        {
           
           if (TxtBoxName.Texts != "")
           {


               if (TxtBoxTel.Text != "")
               {
                   ProveedoresControllers proveedoresControllers = new ProveedoresControllers();
                   Proveedor proveedor = new Proveedor();
                   proveedor.nombre_proveedor = TxtBoxName.Texts;
                   proveedor.telefono_proveedor = TxtBoxTel.Text;
                   proveedoresControllers.Post(proveedor);
                   Clear();
                   DialogResult result = RJMessageBox.Show("Nuevo proveedor añadido con éxito.","Aviso!");

                   if (callback != null) {callback();}
               }
               else
               {
                  DialogResult result = RJMessageBox.Show("Campo teléfono vacío.",
                           "Aviso!");
               }


           }

            
            else
            {
                DialogResult result = RJMessageBox.Show("Campo de nombre vacío.",
                           "Aviso!");
            }
        }

        private void Clear()
        {
            TxtBoxName.Texts = "";
            TxtBoxTel.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

