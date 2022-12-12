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
using MarDeCortezDsk.UserControlls;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class UserConfig : UserControl
    {
        public UserConfig()
        {
            InitializeComponent();
        }



        private void UserConfig_Load(object sender, EventArgs e)
        {
            StartPage();
        }

        public Usuarios Usuario { get; set; }
        botonesEdicion botonesEdicion = new botonesEdicion() { Location = new Point(496, 116) };

        public void StartPage()
        {
            TitleBar.Text = "Configuración de usuarios";
            TitleBar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            CofiguariosUsuarios cofiguariosUsuarios = new CofiguariosUsuarios() { Location = new Point(0,0)};
            cofiguariosUsuarios.Crear += new CofiguariosUsuarios.CrearDelegate(Crear);
            cofiguariosUsuarios.Editar += new CofiguariosUsuarios.DelegateEditar(Actualizar);
            cofiguariosUsuarios.GetUsuario += new CofiguariosUsuarios.GetUsuarioDelegate(RefreshUser);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(cofiguariosUsuarios);


        }

        public void Crear()
        {
            TitleBar.Text = "Creación de usuarios";
            NuevoUsuario nuevo = new NuevoUsuario() { Location = new Point(0, 0) };
            nuevo.OnBack += new NuevoUsuario.backDelegate(StartPage);
            nuevo.TitleChange += new NuevoUsuario.TitleDelegate(UpdateTitle);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(nuevo);
        }

        public void Actualizar()
        {
            TitleBar.Text = "Modificación de usuarios";
            NuevoUsuario actualizar = new NuevoUsuario(Usuario) { Location = new Point(0, 0) };
            actualizar.OnBack += new NuevoUsuario.backDelegate(StartPage);
            actualizar.TitleChange += new NuevoUsuario.TitleDelegate(UpdateTitle);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(actualizar);
        }

        public void RefreshUser(Usuarios usuario)
        {
            Usuario = usuario;
            
        }

        public void UpdateTitle(string title) 
        {
            TitleBar.Text = title;
            
        }

        public void SideBtnLocation(Point location)
        {
            botonesEdicion.Location = location;
        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
        }

        private void UsuariosContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
