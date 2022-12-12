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
using MarDeCortezDsk.Styles;



namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class ListaUsuarios : UserControl
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }
        public ListaUsuarios(Point point)
        {
            InitializeComponent();
            SideBtnLocationStart = point;

        }

        public Point SideBtnLocationStart { get; set; }

        public delegate void GetUsuarioDelegate(Usuarios usuario);
        public event GetUsuarioDelegate GetUsuario;

        public delegate void ButtonsLocationDelegate(Point point);
        public event ButtonsLocationDelegate SideBtnLocation;

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(List<Usuarios> listausuarios)
        {
            UsuarioController userServise = new UsuarioController();
            int index;
            foreach (Usuarios element in listausuarios)
            {
                index = DatagridUsuarios.RowCount;
                Usuarios user = userServise.Get(element.id_usuario);

                DatagridUsuarios.Rows.Insert(index, element.id_usuario, element.nombre_usuario, element.tipo_usuario, element.password);

            }
        }
        public void LoadData()
        {
            UsuarioController userServise = new UsuarioController();
            List<Usuarios> listaUsuarios = userServise.Get();
            int index;
            foreach (Usuarios element in listaUsuarios)
            {
                index = DatagridUsuarios.RowCount;
                Usuarios user = userServise.Get(element.id_usuario);

                DatagridUsuarios.Rows.Insert(index, element.id_usuario, element.nombre_usuario, element.tipo_usuario, element.password);

            }
        }
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioController UserService = new UsuarioController();
            LoadData(UserService.Get());
            DatagridUsuarios.Rows[0].Selected = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }

        private void DatagridFolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioController userServise = new UsuarioController();
            Usuarios Usuario = userServise.Get(DatagridUsuarios.CurrentRow.Cells[0].Value.ToString());
            GetUsuario(Usuario);
            MessageBox.Show (Cursor.Position.Y.ToString());
            SideBtnLocation(SideBtnLocationUpdate());

        }

        private Point SideBtnLocationUpdate()
        {

            Animations animations = new Animations();
            Point location = animations.BtnlocationDatagrid(DatagridUsuarios, 340, Cursor.Position.Y, SideBtnLocationStart, 12);
            return location;
        }

        public void Delete()
        {
            UsuarioController userController = new UsuarioController();
            DatagridUsuarios.Rows.Remove(DatagridUsuarios.CurrentRow);
            userController.Delete(DatagridUsuarios.CurrentRow.Cells[0].Value.ToString());

        }

        public void Clear()
        {
            DatagridUsuarios.Rows.Clear();
        }
    }
}
