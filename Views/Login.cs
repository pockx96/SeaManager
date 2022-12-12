using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Views;
using CustomMessageBox;

namespace MarDeCortezDsk
{
    public partial class Login : Form
    {
        //metodos

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBox_user.GotFocus += new EventHandler(this.TextGotFocus);
            txtBox_user.LostFocus += new EventHandler(this.TextLostFocus);
            txtBox_psswrd.GotFocus += new EventHandler(this.TextGotFocuspass);
            txtBox_psswrd.LostFocus += new EventHandler(this.TextLostFocuspass);


        }

        private void txtBox_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
          

            


        }

        private void containerLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtBox_user.Text == "Usuario")
            {
                txtBox_user.Text = "";
                txtBox_user.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtBox_user.Text == "")
            {
                txtBox_user.Text = "Usuario";
                txtBox_user.ForeColor = Color.LightGray;
            }
        }
        public void TextGotFocuspass(object sender, EventArgs e)
        {

            if (txtBox_psswrd.Text == "Contraseña")
            {
                txtBox_psswrd.Text = "";
                txtBox_psswrd.ForeColor = Color.Black;
            }
        }

        public void TextLostFocuspass(object sender, EventArgs e)
        {

            if (txtBox_psswrd.Text == "")
            {
                txtBox_psswrd.Text = "Contraseña";
                txtBox_psswrd.ForeColor = Color.LightGray;
            }
        }
        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioController UserServise = new UsuarioController();
            Usuarios UsuarioValidator = UserServise.Get(txtBox_user.Texts);

            if (txtBox_user.Texts == "" || txtBox_user.Texts == "Usuario")
            {
                DialogResult result = RJMessageBox.Show("Campo Usuario Vacio, por favor asegurese de completarlo.",
              "Aviso!");

            }
            else if (txtBox_psswrd.Texts == "" || txtBox_psswrd.Texts == "Contraseña")
            {
                DialogResult result = RJMessageBox.Show("Campo contraseña vacio por favor asegurese de completarlo.",
                "Aviso!");
            }
            else if (txtBox_user.Texts != UsuarioValidator.id_usuario)
            {
                DialogResult result = RJMessageBox.Show("Usuario incorrecto.",
                "Aviso!");
            }
            else if (txtBox_psswrd.Texts != UsuarioValidator.password)
            {
                DialogResult result = RJMessageBox.Show("Contraseña incorrecta.",
                "Aviso!");
            }
            else if (txtBox_user.Texts == UsuarioValidator.id_usuario && txtBox_psswrd.Texts == UsuarioValidator.password )
            {
               if (UsuarioValidator.tipo_usuario == "Usuario\t")
               {
                    DialogResult result = RJMessageBox.Show("Bienvenido " + UsuarioValidator.nombre_usuario + " !.", "Aviso!");
                    MenuUser menu = new MenuUser(UsuarioValidator.id_usuario);
                    menu.Show();
                    this.Hide();
               }
               else if (UsuarioValidator.tipo_usuario == "Administrador")
               {
                    DialogResult result = RJMessageBox.Show("Bienvenido " + UsuarioValidator.nombre_usuario + " !.", "Aviso!");
                    MenuAdmin menu = new MenuAdmin(UsuarioValidator.id_usuario);
                    menu.Show();
                    this.Hide();
                }
            }

            /*try
            {
                string Username = txtBox_user.Texts;
                string Userpass = txtBox_psswrd.Texts;
                string ValidatorPass = "";
                string ValidatorRol = "";

                if (Username != "" && Userpass != "")
                {
                    Usuarios usuario = UserServise.Get(Username);


                    if (usuario.id_usuario == Username)
                    {
                        ValidatorPass = usuario.password;
                        ValidatorRol = usuario.tipo_usuario;
                        if (ValidatorPass == Userpass && ValidatorRol == "Usuario\t")
                        {
                            DialogResult result = RJMessageBox.Show("Bienvenido " + usuario.nombre_usuario + " !.", "Aviso!");
                            MenuUser menu = new MenuUser(usuario.id_usuario);
                            menu.Show();
                            this.Hide();

                        }
                        else if (ValidatorPass == Userpass && ValidatorRol == "Administrador")
                        {
                            DialogResult result = RJMessageBox.Show("Bienvenido " + usuario.nombre_usuario + " !.", "Aviso!");
                            MenuAdmin menu = new MenuAdmin(usuario.id_usuario);
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            DialogResult result = RJMessageBox.Show("Contraseña incorrecta.", "Aviso!");
                            txtBox_psswrd.BorderColor = Color.Red;
                        }
                    }
                    else
                    {
                        DialogResult result = RJMessageBox.Show("Usuario no encontrado.", "Aviso!");
                        txtBox_user.BorderColor = Color.Red;
                    }


                }
                else
                {
                    DialogResult result = RJMessageBox.Show("Por favor asegurese de rellenar todos los campos.", "Aviso!");
                    txtBox_psswrd.BorderColor = Color.Red;
                    txtBox_user.BorderColor = Color.Red;

                }
            }
            catch
            {


            }*/

        }
    

        private void EyeButton_Click(object sender, EventArgs e)
        {
            if (txtBox_psswrd.PasswordChar == true)
            {
                EyeButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtBox_psswrd.PasswordChar = false;
            }
            else
            {
                EyeButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtBox_psswrd.PasswordChar = true;
            }
        }


        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
