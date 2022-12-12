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
using MarDeCortezDsk.Models;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Styles;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class CofiguariosUsuarios : UserControl
    {
        public CofiguariosUsuarios()
        {
            InitializeComponent();
        }

        public delegate void GetUsuarioDelegate(Usuarios usuarios);
        public event GetUsuarioDelegate GetUsuario;


        public delegate void CrearDelegate();
        public event CrearDelegate Crear;

        public delegate void DelegateEditar();
        public event DelegateEditar Editar;

       public delegate void DelegateDetalles();
        public event DelegateDetalles Detalles;


        private void DatagridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point location = animations.BtnlocationDatagrid(DatagridUsuarios,340,Cursor.Position.Y,new Point(460, 116),12);
            BotonesEdicion.Location = location;
            UsuarioController usuarioServise = new UsuarioController();
            Usuarios usuarios = usuarioServise.Get(DatagridUsuarios.CurrentRow.Cells[0].Value.ToString());
            GetUsuario(usuarios);
            DatagridUsuarios.CurrentRow.Selected = true;
        }

        private void CofiguariosUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioController userServise = new UsuarioController();
            List<Usuarios> listaUsuarios = userServise.Get();
            int index;
            foreach (Usuarios element in listaUsuarios)
            {
                index = DatagridUsuarios.RowCount;
                DatagridUsuarios.Rows.Insert(index, element.id_usuario, element.nombre_usuario, element.tipo_usuario, element.password);

            }

            labelCrear labelCrear = new labelCrear("Crear nuevo usuario"){ Location = new Point(44, 26) };
            this.Controls.Add(labelCrear);
            if (Editar != null && Crear != null)
            {

                BotonesEdicion.eliminar += new botonesEdicion.eliminarDelegate(Eliminar);
                BotonesEdicion.editar += new botonesEdicion.editarDelegate(Editar);
                labelCrear.Crear += new labelCrear.CrearDelegate(Crear);

            }

            /*/DatagridUsuarios.CurrentRow.Selected = true;*/
        }

        private void Eliminar()
        {
            if (DatagridUsuarios.Rows.Count>0)
            {
                UsuarioController UserServide = new UsuarioController();
                UserServide.Delete(DatagridUsuarios.CurrentRow.Cells[0].Value.ToString());
                DatagridUsuarios.Rows.Remove(DatagridUsuarios.CurrentRow);

            }
        }

        private void BotonesEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
