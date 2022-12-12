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

namespace MarDeCortezDsk
{
    public partial class Login : Form
    {
        //metodos
        Dictionary<string, string> Usuarios = new Dictionary<string, string>(){    {"useremp", "empleado"},{"passwordemp", "empleado123"}, { "userad", "admin" }, { "passwordad", "admin123" }, { "tester", "Usuario" }, { "testercont", "Contraseña" } };

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void txtBox_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
          

            try
            {
                Conections conn = new Conections();
                string Username = txtBox_user.Text;
                string Userpass = txtBox_psswrd.Text;
                List<Usuarios> user = conn.GetUsuarios(Username);
                string validadorContraseña = Convert.ToString(user[0].password);
                string validadorUsuario = Convert.ToString(user[0].tipo_usuario);

                if (Userpass == validadorContraseña)
                {

                    if (validadorUsuario == "user                ")
                    {
                        Form bttaeleemp = new MenuElecc();
                        this.Hide();
                        bttaeleemp.Show();
                        lklb_createacoount.Visible = true;

                    }
                    else if (validadorUsuario == "admin               ")
                    {
                        Form bttaeleemp = new MenuCotroller();
                        this.Hide();
                        bttaeleemp.Show();
                        lklb_createacoount.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña es incorrecta");

                    }


                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");

                }
            }
            catch
            {
                MessageBox.Show("El usuario es incorrecto");


            }


        }

        private void containerLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
