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
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Views;
using CustomMessageBox;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Text;

namespace MarDeCortezDsk.UserControlls
{
    public partial class CarritoProducto : UserControl
    {
        public CarritoProducto(Folios folios,bool _SumaTrue_RestaFalse)
        {
            InitializeComponent();
            FoliosController foliosController = new FoliosController();
            this.Folio = folios;
            LblFolio.Text = foliosController.NewId();
            if (_SumaTrue_RestaFalse)
            {
                this.Post += new PostDelegate(SumasInventarios);
            }
            else
            {
                this.Post += new PostDelegate(RestasInventarios);
            }


        }

        public CarritoProducto()
        {
            InitializeComponent();
            this.Post += new PostDelegate(SumasInventarios);

        }
        
        bool IsEmptyCell = false;

        public Folios Folio { get; set; }

        public Inventario Inventario{get; set;}

        private string formularioActual { get; set; }

        public PescadoFicha PescadoFicha = new PescadoFicha();
        public OtrosFicha OtrosFicha = new OtrosFicha();

        PescadoFicha formPescado = new PescadoFicha() { Location = new Point(0, 0) };
        OtrosFicha formOtro = new OtrosFicha() { Location = new Point(0, 0) };
        FichaCamaron formCamaron = new FichaCamaron() { Location = new Point(0, 0) };

        List<Pescado> ListaPescado = new List<Pescado>();
        List<Camaron> ListaCamaron = new List<Camaron>();

        public delegate void RestartDelegate();
        public event RestartDelegate Restart;

        public delegate void PostDelegate();
        public event PostDelegate Post;

        private void CarritoProducto_Load(object sender, EventArgs e)
        {
            CamaronAdd();

        }

        public void CamaronAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formCamaron);
            formularioActual = "Camaron";
        }
        public void PescadoAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formPescado);
            formularioActual = "Pescado";
        }
        public void OtrosAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formOtro);
            formularioActual = "Otros";
        }



        private void BtnFichas_Click(object sender, EventArgs e)
        {
            Post();

        }


        private void Clear()
        {
            DatagridEntrada.Rows.Clear();
            formCamaron.Clear();
            formPescado.Clear();
            formOtro.Clear();
        }


        private void SumasInventarios()
        {
            PescadoController pescadoController = new PescadoController();
            CamaronController camaronController = new CamaronController();
            FoliosController foliosController = new FoliosController();


            if (DatagridEntrada.RowCount > 0)
            {
                var result = RJMessageBox.Show("¿Desea confirmar esta entrada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foliosController.Post(Folio);
                    foreach (Camaron camaron in ListaCamaron)
                    {
                        camaronController.Post(camaron, Folio.id_proveedor);
                    }

                    foreach (Pescado pescado in ListaPescado)
                    {
                        pescadoController.Post(pescado,Folio.id_proveedor);
                    }
                    DialogResult resul = RJMessageBox.Show("Productos agregados con exito!.",
                     "Aviso!");
                    Clear();
                    Restart();
                }
            }
            else
            {
                DialogResult result = RJMessageBox.Show("Agrege productos al carrito.",
               "Aviso!");
            }
        }
        public void ValidarCelda()
        {
            {

                for (int i = 0; i < DatagridEntrada.RowCount; i++)
                {
                    for (int j = 0; j < DatagridEntrada.ColumnCount; j++)
                    {
                        if (DatagridEntrada.Rows[i].Cells[j].Value == null)
                        {
                            IsEmptyCell = true;
                        }
                    }
                }

            }
        }
        
        private void ImprimiPDF()
        {
            FoliosController foliosController = new FoliosController();
            Folios folioString = foliosController.Get(Folio.IdFolio);
            IsEmptyCell = false;
            string proveedor = folioString.id_proveedor;
            ValidarCelda();
            if (IsEmptyCell == false)
            {
                SaveFileDialog savefile = new SaveFileDialog();//guarda el pdf en una carpeta de destino
                savefile.FileName = string.Format("Salidas", DateTime.Now.ToString("ddMMyyyyHHmm"));//nombra el archivo en base a la fecha 
                savefile.DefaultExt = "pdf";
                string PaginaHTML_Texto = Properties.Resources.PlantillaSalida.ToString();//estructura html esto le da el formaato a el recibo 

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", proveedor);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Folio de ingreso de producto");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Folio", Folio.IdFolio);

                string filas = string.Empty;
                foreach (DataGridViewRow row in DatagridEntrada.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Column1"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column2"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Column3"].Value.ToString() + "</td>";
                    filas += "</tr>";

                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

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
                Folios ficha = fichaEntradaServices.Get(Folio.IdFolio);
                ficha.Estado = "Salida de Producto";
                fichaEntradaServices.Update(ficha);
            }
        }
        private void RestasInventarios()
        {
            PescadoController pescadoController = new PescadoController();
            CamaronController camaronController = new CamaronController();
            FoliosController foliosController = new FoliosController();


            if (DatagridEntrada.RowCount > 0)
            {
                var result = RJMessageBox.Show("¿Desea confirmar esta entrada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Folio.Estado = "Salida de inventario";

                    InventariosController inventariosController = new InventariosController();
                    List<Inventario> listInvetarios = inventariosController.Get(Folio.id_proveedor);
                    foliosController.Post(Folio);
                    
                    foreach (Camaron camaron in ListaCamaron)
                    {
                        string Presentacion = $"{camaron.Presentacion} {camaron.Medida}";


                        foreach (Inventario inventario in listInvetarios)
                        {
                            if (inventario.Proveedor == Folio.id_proveedor && inventario.Presentacion == Presentacion)
                            {
                                inventariosController.Update(inventario, camaron.Cantidad, camaron.Kilos);

                            }
                        }
                    }

                    foreach (Pescado pescado in ListaPescado)
                    {
                        string Presentacion = $"{pescado.Presentacion}";


                        foreach (Inventario inventario in listInvetarios)
                        {
                            if (inventario.Proveedor == Folio.id_proveedor && inventario.Presentacion == Presentacion)
                            {
                                inventariosController.Update(inventario, pescado.Cantidad, pescado.Kilos);

                            }
                        }
                    }

                    ImprimiPDF();
                    DialogResult resul = RJMessageBox.Show("Productos agregados con exito!.",
                     "Aviso!");
                    Clear();
                    Restart();
                }
            }
            else
            {
                DialogResult result = RJMessageBox.Show("Agrege productos al carrito.",
               "Aviso!");
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Post();
            formCamaron.Clear();
            formPescado.Clear();
            formOtro.Clear();
            DatagridEntrada.Rows.Clear();
            ListaCamaron.Clear();
            ListaPescado.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ListaCamaron.Clear();
            ListaPescado.Clear();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            int index = DatagridEntrada.RowCount;
            switch (formularioActual)
            {
                case "Camaron":
                    if (formCamaron.ValidationForm())
                    {
                        Camaron camaron = formCamaron.GetRow(Folio.IdFolio, Folio.id_proveedor);
                        ListaCamaron.Add(camaron);
                        DatagridEntrada.Rows.Insert(index, camaron.Tipo_producto, camaron.Presentacion, camaron.Cantidad);
                        formCamaron.Clear();
                    }
                    break;
                case "Pescado":
                    if (formPescado.ValidationForm())
                    {
                        Pescado pescado = new Pescado()
                        {
                            FolioEntrada = Folio.IdFolio,
                            Almacenaje = Folio.id_proveedor,
                            Tipo_producto = formPescado.TipoPescado,
                            Presentacion =formPescado.PresentacionPescado,
                            Cantidad = formPescado.CantidadPescado,
                            Kilos = KilosCalculation(formPescado.CantidadPescado, formPescado.PresentacionPescado)
                        };
                        DatagridEntrada.Rows.Insert(index, pescado.Tipo_producto, pescado.Presentacion, pescado.Cantidad);
                        ListaPescado.Add(pescado);
                        formPescado.Clear();
                    }
                    break;

                case "Otros":
                    if (formOtro.ValidationForm())
                    {
                        Pescado otroProducto = formOtro.GetProducto(Folio.IdFolio, Folio.id_proveedor);
                        ListaPescado.Add(otroProducto);
                        DatagridEntrada.Rows.Insert(index, otroProducto.Tipo_producto, otroProducto.Presentacion, otroProducto.Cantidad);
                        formOtro.Clear();
                    }
                    break;

            }

       
        }


        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatagridEntrada.RowCount > 1)
            {
                var result = RJMessageBox.Show("¿Desea Eliminar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Camaron camaronDelete = ListaCamaron.Where(c => c.IdProducto == DatagridEntrada.CurrentRow.Cells[0].Value.ToString()).First();
                    Pescado pescadoDelete = ListaPescado.Where(c => c.IdProducto == DatagridEntrada.CurrentRow.Cells[0].Value.ToString()).First();

                    ListaPescado.Remove(pescadoDelete);
                    ListaCamaron.Remove(camaronDelete);
                    DatagridEntrada.Rows.Remove(DatagridEntrada.CurrentRow);

                }
            }
        }

        public float KilosCalculation(int cantidad, string presentacion)
        {
            float kilos;
            switch (presentacion)
            {
                case "kileado":
                    kilos = cantidad;
                    return kilos;
                case "dos kilos":
                    kilos = cantidad * 2;
                    return kilos;
                case "cinco kilos":
                    kilos = cantidad * 5;
                    return kilos;
                case "diez kilos":
                    kilos = cantidad * 10;
                    return kilos;
                case "al vacio":
                    kilos = cantidad;
                    return kilos;
                case "para disco":
                    kilos = cantidad;
                    return kilos;



                case "de 100 a 500 gramos":
                    kilos = cantidad * .35f;
                    return kilos;
                case "de 800 a 1.2 kilos":
                    kilos = cantidad * .75f;
                    return kilos;
                case "de 1.2 a 1.5 kilos":
                    kilos = cantidad;
                    return kilos;
                case "de 1.5 a 2 kilos":
                    kilos = cantidad * 1.8f;
                    return kilos;
                case "de 3 a 4 kilos":
                    kilos = cantidad * 3.5f;
                    return kilos;
                case "5 kilos":
                    kilos = cantidad * 5;
                    return kilos;
                case "6 kilos":
                    kilos = cantidad * 6;
                    return kilos;
                case "7 kilos":
                    kilos = cantidad * 7;
                    return kilos;
                case "8 kilos":
                    kilos = cantidad * 8;
                    return kilos;
                case "9 kilos":
                    kilos = cantidad * 9;
                    return kilos;
                case "10 kilos":
                    kilos = cantidad * 10;
                    return kilos;
                case "11 kilos":
                    kilos = cantidad * 11;
                    return kilos;



            }
            return 0;
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }
    }

 

    
}
