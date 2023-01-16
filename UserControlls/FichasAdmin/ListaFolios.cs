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
        public ListaFolios()
        {
            InitializeComponent();
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

        FoliosController FoliosController = new FoliosController();
            UsuarioController UserController = new UsuarioController();

        public void LoadData(string estado,string usuario)
        {
            
            DatagridFolios.Rows.Clear();
            
            List<Folios> fichaEntradas = FoliosController.GetByEstado(estado, usuario);
            int index;
            foreach (Folios element in fichaEntradas)
            {
                index = DatagridFolios.RowCount;
                Usuarios user = UserController.Get(element.id_usuario);

                DatagridFolios.Rows.Insert(index, element.IdFolio, element.id_proveedor, element.fecha_entrada, user.nombre_usuario);

            }

        }
        public void LoadData(string estado)
        {

            DatagridFolios.Rows.Clear();
            List<Folios> fichaEntradas = FoliosController.GetByEstado(estado);
           
            int index;
            foreach (Folios element in fichaEntradas)
            {
                index = DatagridFolios.RowCount;
                Usuarios user = UserController.Get(element.id_usuario);

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
            DatagridFolios.CurrentRow.Selected = true;

            if (DatagridFolios.RowCount > 0)
            {
                if (DatagridFolios.Columns[e.ColumnIndex].Name == "borrar")
                {
                    var dialogBoxOption = RJMessageBox.Show("¿Desea Eliminar este folio?", "Advertencia una vez eliminado no podra recuperarse", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogBoxOption == DialogResult.OK)
                    {
                        FoliosController fichaServise = new FoliosController();
                        fichaServise.Delete(DatagridFolios.CurrentRow.Cells[0].Value.ToString());
                        DatagridFolios.Rows.Remove(DatagridFolios.CurrentRow);

                    }
                }
                else if (DatagridFolios.Columns[e.ColumnIndex].Name == "calcular")
                {
                    string folio = DatagridFolios.CurrentRow.Cells[0].Value.ToString();
                    Calcular(folio);
                }

            }

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

        }

        private void LblFinalizados_Click(object sender, EventArgs e)
        {
            LblFinalizados.ForeColor = Color.FromArgb(150,150,150);
            LblPendientes.ForeColor = Color.White;
            LoadData("Finalizado");

        }

        private void TitleBar_MouseEnter(object sender, EventArgs e)
        {
            TitleBar.BackColor = Color.FromArgb(76, 76, 76);
            TitleBar.ForeColor = Color.White;
        }
    }
}
