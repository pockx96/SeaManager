using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Views;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.UserControlls.FichasAdmin;
using MarDeCortezDsk.Models;
using CustomMessageBox;

namespace MarDeCortezDsk.Views
{
    public partial class ProvedorShowDialog : Form
    {
        public ProvedorShowDialog()
        {

            InitializeComponent();

        }
        private void ProvedorShowDialog_Load(object sender, EventArgs e)
        {
            LoadProveedores();
            nuevoProveedor.callback += new NuevoProveedor.CallbackDelegado(ResetScreen);

        }
        public delegate void loadProveedorDelegate(string proveedor, string Usuario, string fecha);
        public event loadProveedorDelegate loadProveedor;




        public string Proveedor { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }   

        NuevoProveedor nuevoProveedor = new NuevoProveedor();


        public string GetProveedor()
        {
            return CmBoxProveedores.Text;
        }

        private void LoadProveedores()
        {
            ProveedoresControllers ProveedorController = new ProveedoresControllers();
            List<Proveedor> Proveedores = new List<Proveedor>();
            Proveedores = ProveedorController.Get();
            foreach (Proveedor proveedor in Proveedores)
            {
                CmBoxProveedores.Items.Add(proveedor.nombre_proveedor);
            }
        }

        private void BtnCalculadoraTotal_Click(object sender, EventArgs e)
        {
            if (CmBoxProveedores.Text != "")
            {
                this.Proveedor = CmBoxProveedores.Text;
                loadProveedor(Proveedor,Usuario,Fecha);
                this.Hide();
                
            }
            else
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione un proveedor antes de continuar.",
               "Aviso!");
            }

        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProveedorAdd_Click(object sender, EventArgs e)
        {
            ContainerForm.Controls.Add(nuevoProveedor);
            nuevoProveedor.Location = new Point(16, 71);
            ContainerProveedor.Visible = false;
        }

        private void ResetScreen()
        {
            ContainerForm.Controls.Remove(nuevoProveedor);
            ContainerProveedor.Visible = true;
            LoadProveedores();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
