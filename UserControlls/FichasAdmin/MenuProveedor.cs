﻿using System;
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
    public partial class MenuProveedor : UserControl
    {
        public MenuProveedor()
        {
            InitializeComponent();
        }



        private void UserConfig_Load(object sender, EventArgs e)
        {
            StartPage();
        }

        public Proveedor Proveedor { get; set; }


        public void StartPage()
        {
            TitleBar.Text = "Configuración de usuarios";
            TitleBar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            ConfiguracionProveedores cofiguariosProveedores = new ConfiguracionProveedores(Crear, Actualizar) { Location = new Point(0,0)};

            cofiguariosProveedores.GetProveedor += new ConfiguracionProveedores.GetProveedorDelegate(RefreshProveedor);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(cofiguariosProveedores);


        }

        public void Crear()
        {
            TitleBar.Text = "Creación de Proveedor";
            NuevoProveedorMenu nuevoProveedor = new NuevoProveedorMenu() { Location = new Point(0, 0) };
            nuevoProveedor.OnBack += new NuevoProveedorMenu.backDelegate(StartPage);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(nuevoProveedor);
        }

        public void Actualizar(Proveedor _proveedor)
        {
            TitleBar.Text = "Modificación de usuarios";
            NuevoProveedorMenu actualizar = new NuevoProveedorMenu(_proveedor) { Location = new Point(0, 0) };
            actualizar.OnBack += new NuevoProveedorMenu.backDelegate(StartPage);
            UsuariosContainer.Controls.Clear();
            UsuariosContainer.Controls.Add(actualizar);
        }

        public void RefreshProveedor(Proveedor proveedor)
        {
            Proveedor = proveedor;
            
        }

        public void UpdateTitle(string title) 
        {
            TitleBar.Text = title;
            
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
