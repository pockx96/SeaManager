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
    public partial class BitacoraView : UserControl
    {
      
        public BitacoraView()
        {
            InitializeComponent();
            BitacoraController bitacoraController = new BitacoraController();
            ListBitacora = bitacoraController.Get();
        }


        List<Bitacora> ListBitacora;
        private void Inventarios_Load(object sender, EventArgs e)
        {
            

            LoadData(ListBitacora);

           

        }



        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadData(List<Bitacora> ListBitacora)
        {
            DatagridBitacora.Rows.Clear();
            int index;


            foreach (Bitacora element in ListBitacora)
            {
                index = DatagridBitacora.RowCount;
                DatagridBitacora.Rows.Insert(index, element.Proceso,element.Usuario,element.Proveedor,element.Fecha);
                

            }
        }

      
   


        private void iconButton3_Click(object sender, EventArgs e)
        {
            int ir = 2;
            int cl = 1;
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 10;
            style.Font.Bold = true;
            foreach (DataGridViewColumn column in DatagridBitacora.Columns)
            {
                sl.SetCellValue(1, cl, column.HeaderText.ToString());
                sl.SetCellStyle(1, cl, style);
                cl++;

            }

            foreach (DataGridViewRow row in DatagridBitacora.Rows)
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

        private void TxtBoxSearch__TextChanged(object sender, EventArgs e)
        {
            var lst = ListBitacora.Where(f => f.Proveedor.Contains(TxtBoxSearch.Texts)).ToList();
            LoadData(lst);

        }
    }

        
    
}
