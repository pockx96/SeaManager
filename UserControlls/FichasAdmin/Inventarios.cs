using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Styles;
using SpreadsheetLight;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class Inventarios : UserControl
    {
      
        public Inventarios()
        {
            InitializeComponent();
            PescadoController PescadoServise = new PescadoController();
            CamaronController CamaronServise = new CamaronController();
        }


        private void Inventarios_Load(object sender, EventArgs e)
        {

            LoadData();

           

        }



        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadData()
        {
            PescadoController pescadoController = new PescadoController();
            List<Pescado> pescadoList = pescadoController.GetByProveedor("Tienda");
            CamaronController camaronController = new CamaronController();
            List<Camaron> CamaronList = camaronController.GetByProveedor("Tienda");
            List<Pescado> ListInventario = pescadoController.MixList(CamaronList, pescadoList);
            DatagridInventario.Rows.Clear();
            int index;
            foreach (Pescado element in ListInventario)
            {
                index = DatagridInventario.RowCount;

                DatagridInventario.Rows.Insert(index, element.IdProducto,element.Tipo_producto, element.Presentacion, element.Cantidad, element.Kilos);

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = DatagridInventario.CurrentRow.Cells[0].Value.ToString();
            char id = idProducto[0];
            InventarioRestasForm inventarioRestas;

            if (id == 'C')
            {
                CamaronController camaronController = new CamaronController();
                Camaron camaron = camaronController.Get(idProducto);
                inventarioRestas = new InventarioRestasForm(camaron);
                inventarioRestas.Load += new InventarioRestasForm.LoadDelegate(LoadData);
                inventarioRestas.ShowDialog();
            }
            else if (id == 'P')
            {
                PescadoController pescadoController = new PescadoController();
                Pescado pescado = pescadoController.Get(idProducto);
                inventarioRestas = new InventarioRestasForm(pescado);
                inventarioRestas.ShowDialog();
            }


        }
        string parteQuery = "Producto";
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parteQuery = comboBox1.Text;
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFichas_Click(object sender, EventArgs e)
        {
            BtnFilter.Visible = false;
            ContainerFilter.Location = new Point(265, 0);
            ContainerFilter.Visible = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ContainerFilter.Visible = false;
            BtnFilter.Visible = true;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            parteQuery = "Producto";
        }

        private void BtnFichas_MouseEnter(object sender, EventArgs e)
        {
            BtnFilter.BackColor = Color.Gray;
        }

        private void BtnFichas_MouseLeave(object sender, EventArgs e)
        {
            BtnFilter.BackColor = Color.Transparent;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Gray;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Transparent;
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (radioButton5.Checked == true)
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP - SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true;");
                string query = "SELECT * FROM Inventario ORDER BY Producto ASC ";// + comboBox1.Text + " like '%" + rjTextBox1.Texts + "%'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                con.Open();
                DataSet data = new DataSet();
                ada.Fill(data, "Inventario");
                DatagridInventario.DataSource = data;
                DatagridInventario.DataMember = "Inventario";
            }*/
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (radioButton3.Checked == true)
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP - SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true;");
                string query = "SELECT * FROM Inventario ORDER BY Stock ASC ";// + comboBox1.Text + " like '%" + rjTextBox1.Texts + "%'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                con.Open();
                DataSet data = new DataSet();
                ada.Fill(data, "Inventario");
                DatagridInventario.DataSource = data;
                DatagridInventario.DataMember = "Inventario";
            }
            */
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            /*

            if (radioButton4.Checked == true)
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP - SINBAG1\\SQLEXPRESS; Initial Catalog = MarDeCortez; Integrated Security = True; Asynchronous Processing = true;");
                string query = "SELECT * FROM Inventario ORDER BY Stock DESC ";// + comboBox1.Text + " like '%" + rjTextBox1.Texts + "%'";
                SqlDataAdapter ada = new SqlDataAdapter(query, con);

                con.Open();
                DataSet data = new DataSet();
                ada.Fill(data, "Inventario");
                DatagridInventario.DataSource = data;
                DatagridInventario.DataMember = "Inventario";
            }
            */
        }


        private void DatagridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Animations animations = new Animations();
            Point LocationEliminar = animations.BtnlocationDatagrid(DatagridInventario, 277, Cursor.Position.Y, new Point(463, 96), 12);
            DatagridInventario.CurrentRow.Selected = true;
            BtnEliminar.Location = LocationEliminar;
            
        }

        private void BtnFichas_Click_1(object sender, EventArgs e)
        {
            BtnFilter.Visible = false;
            ContainerFilter.Location = new Point(409, 13);
            ContainerFilter.Visible = true;
            DatagridInventario.Location = new Point(14, 136);
            BtnEliminar.Visible = false;

        }

        private void sPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged_1(object sender, EventArgs e)
        {
            

        }

        public void LoadInventarios(List<Inventario> inventarios)
        {
            DatagridInventario.Rows.Clear();
            int index;
            foreach (Inventario element in inventarios)
            {
                index = DatagridInventario.RowCount;
                DatagridInventario.Rows.Insert(index, element.Id_producto,element.Producto, element.Presentacion, element.Stock, element.Kilos);

            }
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            DatagridInventario.Location = new Point(14, 77);
            BtnEliminar.Visible = true;
            ContainerFilter.Visible = false;
            ContainerFilter.Location = new Point(202, 393);
            BtnFilter.Visible = true;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int ir = 2;
            int cl = 1;
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 10;
            style.Font.Bold = true;
            foreach (DataGridViewColumn column in DatagridInventario.Columns)
            {
                sl.SetCellValue(1, cl, column.HeaderText.ToString());
                sl.SetCellStyle(1, cl, style);
                cl++;

            }

            foreach (DataGridViewRow row in DatagridInventario.Rows)
            {
                sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                ir++;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = String.Format("Inventario" + DateTime.Now.ToString("ddMMyyyyHHmm"));
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Archivo exportado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

        
    
}
