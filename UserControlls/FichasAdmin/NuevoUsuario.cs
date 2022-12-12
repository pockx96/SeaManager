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
    public partial class NuevoUsuario : UserControl
    {
        public NuevoUsuario()
        {
            InitializeComponent();
            Action += new NuevoUsuario.ActionDelegate(Createuser);

        }
        public NuevoUsuario(Usuarios usuario)
        {
            InitializeComponent();
            if (usuario != null)
            {
                Usuario = usuario;
                Action += new NuevoUsuario.ActionDelegate(UpdateUser);
                TxtBoxId.Texts = usuario.id_usuario;
                TxtBoxId.Enabled = false;
                TxtBoxNombre.Texts = usuario.nombre_usuario;
                TxtBoxPass.Texts = usuario.password;
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

        public Usuarios Usuario { get; set; }


        private void Clear()
        {
            TxtBoxId.Text = "";
            TxtBoxTipoUsuario.Text = "";
            TxtBoxNombre.Text = "";
            TxtBoxPass.Text = "";
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

           if (TxtBoxNombre.Texts != "")
           {
               if (TxtBoxPass.Texts != "")
               {
                   if (TxtBoxTipoUsuario.Text != "")
                   {

                        Action();
                   }

                  else
                  {
                     DialogResult result = RJMessageBox.Show("Campo de usuario vacio.",
                            "Aviso!");
                  }
               }
               else
               {
                  DialogResult result = RJMessageBox.Show("Campo contraseña vacío.",
                            "Aviso!");
               }
           }

           else
           {
             DialogResult result = RJMessageBox.Show("Campo nombre vacío.",
                            "Aviso!");
           }
          
        }

        public void Createuser() 
        {
            UsuarioController UsuarioServise = new UsuarioController();
            Usuarios usuario = new Usuarios();
            usuario.id_usuario = TxtBoxId.Texts;
            usuario.nombre_usuario = TxtBoxNombre.Texts;
            usuario.password = TxtBoxPass.Texts;
            usuario.tipo_usuario = TxtBoxTipoUsuario.Text;

            UsuarioServise.Post(usuario);
            Clear();
            DialogResult result = RJMessageBox.Show("Nuevo usuario añadido con éxito.", "Aviso!");
            OnBack();
        }
        public void UpdateUser()
        {

            UsuarioController UsuarioServise = new UsuarioController();
            Usuarios usuario = new Usuarios() 
            { 
                id_usuario = Usuario.id_usuario,
                nombre_usuario = TxtBoxNombre.Texts,
                password = TxtBoxPass.Texts,
                tipo_usuario = TxtBoxTipoUsuario.Text
            };
            UsuarioServise.Update(usuario);
            Clear();
            DialogResult result = RJMessageBox.Show("El usuario ha sido actualizado con éxito.", "Aviso!");
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