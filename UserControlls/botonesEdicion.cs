using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBox;

namespace MarDeCortezDsk.UserControlls
{
    public partial class botonesEdicion : UserControl
    {
        public botonesEdicion()
        {
            InitializeComponent();
        }


        public delegate void editarDelegate();
        public event editarDelegate editar;


        public delegate void eliminarDelegate();
        public event eliminarDelegate eliminar;


        public delegate void detallerDelegate();
        public event detallerDelegate detalles;

        private void LblEditar_Click(object sender, EventArgs e)
        {
            if (editar != null) { editar(); } 
        }

        private void LblDetalles_Click(object sender, EventArgs e)
        {
            /*detalles();*/
        }

        private void LblEliminar_Click(object sender, EventArgs e)
        {
            if(eliminar != null) 
            { 
                var result = RJMessageBox.Show("¿Esta seguro que desea eliminar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminar();
                }
            }
        }
    }
}
