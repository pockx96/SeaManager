﻿using System;
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
namespace MarDeCortezDsk.UserControlls
{
    public partial class CarritoProducto : UserControl
    {
        public CarritoProducto()
        {
            InitializeComponent();
        }
        public CarritoProducto(string proveedor,string usuario,string fecha)
        {
            InitializeComponent();
            FoliosController foliosController = new FoliosController();
            this.Proveedor = proveedor;
            this.Usuario = usuario;
            this.Fecha = fecha;
            LblFolio.Text = foliosController.NewId();
            

        }

        public string Proveedor { get; set; }
        public string Fecha { get; set; }
        public string Usuario { get; set; }
        public Folios Folio { get; set; }
        private string formularioActual { get; set; }

        public PescadoFicha PescadoFicha = new PescadoFicha();
        public OtrosFicha OtrosFicha = new OtrosFicha();

        PescadoFicha formPescado = new PescadoFicha() { Location = new Point(0, 0) };
        OtrosFicha formOtro = new OtrosFicha() { Location = new Point(0, 0) };
        FichaCamaron formCamaron = new FichaCamaron() { Location = new Point(0, 0) };


        public List<Camaron> ListCamaron = new List<Camaron>();
        public List<Pescado> ListPescado = new List<Pescado>();

        public delegate void RestartDelegate();
        public event RestartDelegate Restart;

        public delegate void PostDelegate();
        public event PostDelegate Post;

        private void CarritoProducto_Load(object sender, EventArgs e)
        {
            CamaronAdd();
            FoliosController foliosController = new FoliosController();
            Folios NewFolio = new Folios()
            {
                IdFolio = foliosController.NewId(),
                id_usuario = Usuario,
                fecha_entrada = Fecha,
                id_proveedor = Proveedor,
                Estado = "Pendiente"
            };
            this.Folio = NewFolio;
            LblFolio.Text = Folio.IdFolio;

            if (Proveedor == "Tienda")
            {
                this.Post += new PostDelegate(UpdateInventario);
            }
            else
            {
                this.Post += new PostDelegate(PostProveedores);
            }
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


        private void BtnEnviar_Click(object sender, EventArgs e)
        {
           

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


        private void PostProveedores()
        {
            PescadoController pescadoController = new PescadoController();
            CamaronController camaronController = new CamaronController();
            FoliosController foliosController = new FoliosController();


            if (DatagridEntrada.RowCount > 0)
            {
                var result = RJMessageBox.Show("¿Desea confirmar esta entrada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (Camaron camaron in ListCamaron)
                    {
                        camaronController.Post(camaron);
                    }

                    foreach (Pescado pescado in ListPescado)
                    {
                        pescadoController.Post(pescado);
                    }
                    foliosController.Post(Folio);
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
        private void UpdateInventario()
        {
            PescadoController pescadoController = new PescadoController();
            CamaronController camaronController = new CamaronController();
            FoliosController foliosController = new FoliosController();


            if (DatagridEntrada.RowCount > 0)
            {
                var result = RJMessageBox.Show("¿Desea confirmar esta entrada?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (Camaron camaron in ListCamaron)
                    {
                        List<Camaron> ListTienda = camaronController.GetByProveedor("Tienda");
                        if (ListTienda.Count == 0)
                        {
                            camaronController.Post(camaron);
                        }
                        foreach (Camaron camaronTienda in ListTienda)
                        {
                            if (camaronTienda.Presentacion == camaron.Presentacion && camaronTienda.Tipo_producto == camaron.Tipo_producto)
                            {
                                camaronController.Update(camaron,true);
                            }
                            else
                            {
                                camaronController.Post(camaron);
                            }
                        }

                    }

                    foreach (Pescado pescado in ListPescado)
                    {
                        List<Pescado> ListTienda = pescadoController.GetByProveedor("Tienda");
                        if (ListTienda.Count == 0)
                        {
                            pescadoController.Post(pescado);
                        }
                        foreach (Pescado pescadoTienda in ListTienda)
                        {
                            if (pescadoTienda.Presentacion == pescado.Presentacion && pescadoTienda.Tipo_producto == pescado.Tipo_producto)
                            {
                                pescadoController.Update(pescado,true);
                            }
                            else
                            {
                                pescadoController.Post(pescado);
                            }
                        }
                    }
                    foliosController.Post(Folio);
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
            ListCamaron.Clear();
            ListPescado.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ListCamaron.Clear();
            ListPescado.Clear();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            int index = DatagridEntrada.RowCount;
            switch (formularioActual)
            {
                case "Camaron":
                    if (formCamaron.ValidationForm())
                    {
                        Camaron camaron = formCamaron.GetRow(Folio.IdFolio, Proveedor);
                        ListCamaron.Add(camaron);
                        DatagridEntrada.Rows.Insert(index, camaron.Tipo_producto, camaron.Presentacion, camaron.Cantidad);
                        formCamaron.Clear();
                    }
                    break;
                case "Pescado":
                    if (formPescado.ValidationForm())
                    {
                        Pescado pescado = formPescado.GetProducto(Folio.IdFolio, Proveedor);
                        ListPescado.Add(pescado);
                        DatagridEntrada.Rows.Insert(index, pescado.Tipo_producto, pescado.Presentacion, pescado.Cantidad);
                        formPescado.Clear();
                    }
                    break;
                case "Otros":
                    if (formOtro.ValidationForm())
                    {
                        Pescado otros = formOtro.GetProducto(Folio.IdFolio, Proveedor);
                        ListPescado.Add(otros);
                        DatagridEntrada.Rows.Insert(index, otros.Tipo_producto, otros.Presentacion, otros.Cantidad);
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
                    Camaron camaronDelete = ListCamaron.Where(c => c.IdProducto == DatagridEntrada.CurrentRow.Cells[0].Value.ToString()).First();
                    Pescado pescadoDelete = ListPescado.Where(c => c.IdProducto == DatagridEntrada.CurrentRow.Cells[0].Value.ToString()).First();

                    ListPescado.Remove(pescadoDelete);
                    ListCamaron.Remove(camaronDelete);
                    DatagridEntrada.Rows.Remove(DatagridEntrada.CurrentRow);

                }
            }
        }
    }

 

    
}
