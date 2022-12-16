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
using FontAwesome.Sharp;
using CustomMessageBox;

namespace MarDeCortezDsk.UserControlls
{
    public partial class ListaFolios : UserControl
    {
        public ListaFolios(string usuarios)
        {
            InitializeComponent();
            Usuario = usuarios;
        }

        private void ListaFolios_Load(object sender, EventArgs e)
        {
            LoadData("Pendiente");
            if (DatagridFolios.Rows.Count>0)
            {
                DatagridFolios.CurrentRow.Selected = true;
            }
        }

        public delegate void CalcularDelegate(string folio);
        public event CalcularDelegate Calcular;
        string Usuario { get; set; }


        public void LoadData(string estado,string usuario)
        {
            
            DatagridFolios.Rows.Clear();
            FoliosController fichaServise = new FoliosController();
            List<Folios> fichaEntradas = fichaServise.GetByEstado(estado, usuario);
            UsuarioController userServise = new UsuarioController();
            int index;
            foreach (Folios element in fichaEntradas)
            {
                index = DatagridFolios.RowCount;
                Usuarios user = userServise.Get(element.id_usuario);

                DatagridFolios.Rows.Insert(index, element.IdFolio, element.id_proveedor, element.fecha_entrada, user.nombre_usuario);

            }

        }
        public void LoadData(string estado)
        {

            DatagridFolios.Rows.Clear();
            FoliosController fichaServise = new FoliosController();
            List<Folios> fichaEntradas = fichaServise.GetByEstado(estado);
            UsuarioController userServise = new UsuarioController();
            int index;
            foreach (Folios element in fichaEntradas)
            {
                index = DatagridFolios.RowCount;
                Usuarios user = userServise.Get(element.id_usuario);

                DatagridFolios.Rows.Insert(index, element.IdFolio, element.id_proveedor, element.fecha_entrada, user.nombre_usuario);

            }

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (DatagridFolios.RowCount > 1)
            {
                string folio = DatagridFolios.CurrentRow.Cells[0].Value.ToString();
                Calcular(folio);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DatagridFolios.RowCount > 1)
            {
                var result = RJMessageBox.Show("¿Desea Eliminar este folio?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    FoliosController fichaServise = new FoliosController();
                    fichaServise.Delete(DatagridFolios.CurrentRow.Cells[0].Value.ToString());
                    DatagridFolios.Rows.Remove(DatagridFolios.CurrentRow);
                    
                }
            }

        }

        private void DatagridFolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point DeleteLocation = animations.BtnlocationDatagrid(DatagridFolios,305,Cursor.Position.Y,new Point(496, 133),12);
            BtnEliminar.Location = DeleteLocation;
            Point CalcularLocation = animations.BtnlocationDatagrid(DatagridFolios, 305, Cursor.Position.Y, new Point(535, 133), 12);
            BtnCalcular.Location = CalcularLocation;
            DatagridFolios.CurrentRow.Selected = true;
        }


        public  string GetProvedor()
        {
            return DatagridFolios.CurrentRow.Cells[0].Value.ToString().Replace(" ", String.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LblFinalizados.ForeColor = Color.White;
            LblPendientes.ForeColor = Color.FromArgb(150, 150, 150);
            LoadData("Pendiente");
            BtnCalcular.IconChar = IconChar.Calculator;

        }

        private void LblFinalizados_Click(object sender, EventArgs e)
        {
            LblFinalizados.ForeColor = Color.FromArgb(150,150,150);
            LblPendientes.ForeColor = Color.White;
            LoadData("Finalizado");
            BtnCalcular.IconChar = IconChar.InfoCircle;

        }

    }
}
