using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;
using CustomMessageBox;
using MarDeCortezDsk.Styles;
using MarDeCortezDsk.Views;
using SpreadsheetLight;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class CalculadoraFichas : UserControl
    {
        public CalculadoraFichas(string folio)
        {
            InitializeComponent();
            this.Folio = folio;

        }
        public string Folio { get; set; }
        double TotalText { get; set; }

        public delegate void ReturnDelegate();
        public event ReturnDelegate Return;

        private void CalculadoraFichas_Load(object sender, EventArgs e)
        {
            if (ListaEntrada.Rows.Count>0)
            {
                ListaEntrada.Rows[0].Selected = true;
            }
        }

        public void Clear()
        {
            ListaEntrada.Rows.Clear();
            LblTotal.Text = string.Empty;
        }


        public void LoadData(string fichaEntradas)
        {
            FoliosController FichasServise = new FoliosController();
            CamaronController CamaronServise = new CamaronController();
            PescadoController PescadoServise = new PescadoController();


            List<Pescado> ListPescados = PescadoServise.GetByFolio(fichaEntradas);
            List<Camaron> ListCamarones = CamaronServise.GetbyFolio(fichaEntradas);
            List<Pescado> ListMix = PescadoServise.MixList(ListCamarones, ListPescados);

            var ListSort = from p in ListMix
                           orderby p.Tipo_producto
                           select p;
            int index;

            foreach (Pescado element in ListSort)
            {
                index = ListaEntrada.RowCount;
                ListaEntrada.Rows.Insert(index, element.Tipo_producto, element.Presentacion, element.Kilos, element.Cantidad);
            }


        }




        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point LocationEliminar = animations.BtnlocationDatagrid(ListaEntrada, 263, Cursor.Position.Y, new Point(522, 131), 12);
            BtnEliminar.Location = LocationEliminar;
            ListaEntrada.CurrentRow.Selected = true;
            
        }

        private void ListaEntrada_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
        }

        private void ListaEntrada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaEntrada.CurrentRow != null)
            {


                double costo = Convert.ToUInt32(ListaEntrada.CurrentRow.Cells[4].Value);
                double cantidad = Convert.ToUInt32(ListaEntrada.CurrentRow.Cells[3].Value);

                double subtotal = costo * cantidad;


                ListaEntrada.CurrentRow.Cells[5].Value = Convert.ToString(subtotal);

                double total = 0;
                foreach (DataGridViewRow element in ListaEntrada.Rows)
                {
                    total += Convert.ToDouble(element.Cells[5].Value);
                }

                LblTotal.Text = total.ToString("C");




            }

        }

        private void ListaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            IsEmptyCell = false;
            ValidarCelda();
            if (IsEmptyCell == false)
            {
                SaveFileDialog savefile = new SaveFileDialog();//guarda el pdf en una carpeta de destino
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmm"));//nombra el archivo en base a la fecha 
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();//estructura html esto le da el formaato a el recibo 
                                                                                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", comboBox1.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "ficha de proveedor");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Folio", Folio);

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in ListaEntrada.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Column1"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column2"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Kilos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column3"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CxU"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total = decimal.Parse(row.Cells["CxU"].Value.ToString()) * decimal.Parse(row.Cells["Column3"].Value.ToString());

                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", LblTotal.Text);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Icono, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        //pdfDoc.Add(new Phrase());
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
            else
            {
                DialogResult result = RJMessageBox.Show("Por favor asegurese de no dajar celdas vacias.",
               "Aviso!");

            }




        }
        bool IsEmptyCell = false;
        public void ValidarCelda()
        {
            {

                for (int i = 0; i < ListaEntrada.RowCount; i++)
                {
                    for (int j = 0; j < ListaEntrada.ColumnCount; j++)
                    {
                        if (ListaEntrada.Rows[i].Cells[j].Value == null)
                        {
                            IsEmptyCell = true;
                        }
                    }
                }

            }
        }
    




        private void TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void ListaEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculadoraFichas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("");
        }

        private void ListaEntrada_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(ListaEntrada.CurrentRow.Cells[5].Value);
            TotalText -= costo;
            LblTotal.Text = TotalText.ToString("C");
            ListaEntrada.Rows.Remove(ListaEntrada.CurrentRow);
        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            IsEmptyCell = false;
            ValidarCelda();
            if (IsEmptyCell == false)
            {
                SaveFileDialog savefile = new SaveFileDialog();//guarda el pdf en una carpeta de destino
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmm"));//nombra el archivo en base a la fecha 
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();//estructura html esto le da el formaato a el recibo 
                                                                                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", comboBox1.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Folio de ingreso de producto");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in ListaEntrada.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Column1"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column2"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Kilos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column3"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CxU"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total = decimal.Parse(row.Cells["CxU"].Value.ToString()) * decimal.Parse(row.Cells["Column3"].Value.ToString());

                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", LblTotal.Text);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Icono, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        //pdfDoc.Add(new Phrase());
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }

                FoliosController fichaEntradaServices = new FoliosController();
                Folios ficha = fichaEntradaServices.Get(Folio);
                ficha.Estado = "Finalizado";
                fichaEntradaServices.Update(ficha);
                DialogResult result = RJMessageBox.Show("Folio registrado con exito.","Aviso!");
                Return();
            }
        
        }


        private void BtnFichas_Click(object sender, EventArgs e)
        {
            IsEmptyCell = false;
            ValidarCelda();
            if (IsEmptyCell == false)
            {
                SaveFileDialog savefile = new SaveFileDialog();//guarda el pdf en una carpeta de destino
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmm"));//nombra el archivo en base a la fecha 
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();//estructura html esto le da el formaato a el recibo 
                                                                                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", comboBox1.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Solo Cotizacion ");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in ListaEntrada.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Column1"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column2"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Kilos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column3"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CxU"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total = decimal.Parse(row.Cells["CxU"].Value.ToString()) * decimal.Parse(row.Cells["Column3"].Value.ToString());

                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", LblTotal.Text);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Icono, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);
                        //Cotizacion
                        iTextSharp.text.Image ejemplo = iTextSharp.text.Image.GetInstance(Properties.Resources.ejemplo, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ejemplo.ScaleToFit(150, 150);
                        ejemplo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                        ejemplo.SetAbsolutePosition(pdfDoc.LeftMargin + 40, pdfDoc.Top - 100);

                        pdfDoc.Add(ejemplo);
                        //pdfDoc.Add(new Phrase());
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }

            }


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int ir = 2;
            int cl = 1;
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 10;
            style.Font.Bold = true;
            foreach (DataGridViewColumn column in ListaEntrada.Columns)
            {
                sl.SetCellValue(1, cl, column.HeaderText.ToString());
                sl.SetCellStyle(1, cl, style);
                cl++;

            }

            foreach (DataGridViewRow row in ListaEntrada.Rows)
            {
                sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(ir, 6, row.Cells[5].Value.ToString());
                ir++;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = String.Format("Cotizacion" +DateTime.Now.ToString("ddMMyyyyHHmm"));
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
 

