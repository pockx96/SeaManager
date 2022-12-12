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
    public partial class NuevoProveedorMenu : UserControl
    {
        public NuevoProveedorMenu()
        {
            InitializeComponent();
            Action += new NuevoProveedorMenu.ActionDelegate(CreateProveedor);

        }
        public NuevoProveedorMenu(Proveedor proveedor)
        {
            InitializeComponent();
            if (proveedor != null)
            {
                Proveedor = proveedor;
                Action += new NuevoProveedorMenu.ActionDelegate(UpdateProveedor);
                TxtBoxNombre.Texts = proveedor.nombre_proveedor;
                TxtBoxTelefono.Texts = proveedor.telefono_proveedor;
            }

        }

        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            labelCrear lbl = new labelCrear("Volver") { Location = new Point(55, 400) };
            this.Controls.Add(lbl);
            if(OnBack != null)
            {
                lbl.Crear += new labelCrear.CrearDelegate(OnBack);
            }
        }



        public delegate void backDelegate();
        public event backDelegate OnBack;
        
        public delegate void ActionDelegate();
        public event ActionDelegate Action;

        public delegate void TitleDelegate(string title);
        public event TitleDelegate TitleChange;

        public Proveedor Proveedor { get; set; }
        ProveedoresControllers ProveedorServise = new ProveedoresControllers();

        private void Clear()
        {
            TxtBoxNombre.Text = "";
            TxtBoxTelefono.Text = "";
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

           if (TxtBoxNombre.Texts != "")
           {
               if (TxtBoxTelefono.Texts != "")
               {
                    Action();
                }
               else
               {
                  DialogResult result = RJMessageBox.Show("Campo Telefono vacío.",
                            "Aviso!");
               }
           }

           else
           {
             DialogResult result = RJMessageBox.Show("Campo nombre vacío.",
                            "Aviso!");
           }
          
        }

        public void CreateProveedor() 
        {
            Proveedor proveedor = new Proveedor() 
            {
                nombre_proveedor = TxtBoxNombre.Texts,
                telefono_proveedor = TxtBoxTelefono.Texts,
            };
            ProveedorServise.Post(proveedor);
            Clear();
            DialogResult result = RJMessageBox.Show("Nuevo proveedor añadido con éxito.", "Aviso!");
            OnBack();
        }
        public void UpdateProveedor()
        {
            Proveedor proveedor = new Proveedor()
            {
                id_proveedor = Proveedor.id_proveedor,
                nombre_proveedor = TxtBoxNombre.Texts,
                telefono_proveedor = TxtBoxTelefono.Texts,
            };
            ProveedorServise.Update(proveedor);
            Clear();
            DialogResult result = RJMessageBox.Show("Nuevo proveedor actualizado con éxito.", "Aviso!");
            OnBack();

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
    }
}