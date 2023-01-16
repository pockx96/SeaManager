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

        CofiguariosUsuarios MainUsuariosView;
        NuevoUsuario nuevoUsuarioView;
        NuevoUsuario actualizarUsuarios;
        private void UserConfig_Load(object sender, EventArgs e)
        {
            MainUsuariosView = new CofiguariosUsuarios(Crear,Actualizar) { Location = new Point(0, 0) };
            nuevoUsuarioView = new NuevoUsuario() { Location = new Point(0, 0) };
            nuevoUsuarioView.OnBack += new NuevoUsuario.backDelegate(StartPage);
            nuevoUsuarioView.TitleChange += new NuevoUsuario.TitleDelegate(UpdateTitle);           
            StartPage();


        }

        public Usuarios Usuario { get; set; }
        botonesEdicion botonesEdicion = new botonesEdicion() { Location = new Point(496, 116) };

        public void StartPage()
        {
            UsuariosContainer.Controls.Add(MainUsuariosView);
            TitleBar.Text = "Configuración de usuarios";
            TitleBar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(MainUsuariosView);
            MainUsuariosView.LoadData();

        }

        public void Crear()
        {
            TitleBar.Text = "Creación de usuarios";

            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(nuevoUsuarioView);
        }

        public void Actualizar(Usuarios usuarios)
        {
            actualizarUsuarios = new NuevoUsuario(usuarios) { Location = new Point(0, 0) };
            actualizarUsuarios.OnBack += new NuevoUsuario.backDelegate(StartPage);
            TitleBar.Text = "Modificación de usuarios";
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(actualizarUsuarios);
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

        }

        private void UsuariosContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
