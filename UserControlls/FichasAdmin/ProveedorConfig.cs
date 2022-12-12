using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class ProveedorConfig : UserControl
    {
        public ProveedorConfig()
        {
            InitializeComponent();
        }

        private void ProveedorConfig_Load(object sender, EventArgs e)
        {
            StartPage();
        }
        public void StartPage()
        {
            TitleBar.Text = "Configuración de proveedores";
            TitleBar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            labelCrear lblCrear = new labelCrear("Crear nuevo proveedor") { Location = new Point(29, 31) };
            ListaProveedores lstUsuarios = new ListaProveedores() { Location = new Point(32, 89) };
            botonesEdicion botonesEdicion = new botonesEdicion() { Location = new Point(496, 116) };
            lblCrear.Crear += new labelCrear.CrearDelegate(Crear);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(lblCrear);
            UsuariosContainer.Controls.Add(lstUsuarios);
            UsuariosContainer.Controls.Add(botonesEdicion);

        }

        public void Crear()
        {
            NuevoProveedor nuevo = new NuevoProveedor() { Location = new Point(0, 0) };
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(nuevo);
        }
    }
}
