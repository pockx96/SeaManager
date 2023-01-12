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
        public CofiguariosUsuarios(CrearDelegate _crear, EditarDelegate _editar)
        {
            InitializeComponent();
            this.Edit += new CofiguariosUsuarios.EditarDelegate(_editar);
            this.Crear += new CofiguariosUsuarios.CrearDelegate(_crear);

        }



        public delegate void CrearDelegate();
        public event CrearDelegate Crear;

        public delegate void EditarDelegate(Usuarios usuarios);
        public event EditarDelegate Edit;

        UsuarioController usuarioController = new UsuarioController();


        private void DatagridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatagridUsuarios.Rows.Count > 0)
            {
                if (DatagridUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Usuarios usuarios = usuarioController.Get(Convert.ToString(DatagridUsuarios.CurrentRow.Cells[0].Value));
                    Edit(usuarios);
                }
                else if (DatagridUsuarios.Columns[e.ColumnIndex].Name == "Borrar")
                {
                    usuarioController.Delete(DatagridUsuarios.CurrentRow.Cells[0].Value.ToString());
                    DatagridUsuarios.Rows.Remove(DatagridUsuarios.CurrentRow);
                }

            }
        }

        private void CofiguariosUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioController userServise = new UsuarioController();
            List<Usuarios> listaUsuarios = userServise.Get();
            int index;
            foreach (Usuarios element in listaUsuarios)
            {
                index = DatagridUsuarios.RowCount;
                DatagridUsuarios.Rows.Insert(index, element.id_usuario, element.nombre_usuario, element.tipo_usuario);

            }

            labelCrear labelCrear = new labelCrear("Crear nuevo usuario"){ Location = new Point(44, 26) };
            labelCrear.Crear += new labelCrear.CrearDelegate(Crear);
            this.Controls.Add(labelCrear);


        }

        private void Eliminar()
        {

        }

        private void BotonesEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
