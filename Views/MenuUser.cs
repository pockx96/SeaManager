using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Styles;
using MarDeCortezDsk.UserControlls.FichasAdmin;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;
using FontAwesome.Sharp;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Views;

namespace MarDeCortezDsk.Views
{
    public partial class MenuUser : Form
    {
        public MenuUser(string usuario)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            MenuContainer.Controls.Add(leftBorderBtn);
            this.Usuario = usuario;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            FichaEntradaAdd();
            ActivateButton(BtnFolios, RGBColors.color1);
            Fecha = CalendarioContainer.Fecha;
            carrito.Restart += new CarritoProducto.RestartDelegate(RestartScreen);
            TitleUsuario.Title(Usuario);
        }

        public string Usuario { get; set; }
        public string Fecha { get; set; }

        public ProvedorShowDialog provedoresShowDialog = new ProvedorShowDialog();
        CarritoProducto carrito = new CarritoProducto() { Location = new Point(0, 0) };

        Animations animations = new Animations();
        private delegate void BackDelegate();
        private event BackDelegate Back;

  


        


        ////////////////////////////////////////// BOTONES LATERALES ///////////////////////////////////////////////////////////////////

        /// <summary>
        /// Boton de folios
        /// <summary>
        private void FichaEntradaAdd()
        {
            ListaFolios listaFolios = new ListaFolios(Usuario);
            listaFolios.LoadData("Pendiente",Usuario);
            listaFolios.Calcular += new ListaFolios.CalcularDelegate(Calcular);
            BtnBack.Visible = false;
            listaFolios.Location = new Point(0,0);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(listaFolios);

        }
        private void BtnFichas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            FichaEntradaAdd();
            RestartScreen();

        }




        public void Calcular(string folio)
        {
            CalculadoraFichas Calculadora = new CalculadoraFichas(folio);
            Calculadora.Location = new Point(0, 0);
            Calculadora.Clear();
            Calculadora.LoadData(folio);
            Calculadora.Return += new CalculadoraFichas.ReturnDelegate(FichaEntradaAdd);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(Calculadora);
            BtnBack.Visible = true;
            this.Back += new BackDelegate(RestartScreen);

        }

        /// <summary>
        /// Boton de inventario
        /// </summary>

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

            Inventarios inventarios = new Inventarios();
            inventarios.Location = new Point(140, 6);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(inventarios);
            BtnBack.Visible = false;
        }



        /// <summary>
        /// Boton Agregar Provedoor
        /// </summary>

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            MenuProveedor proveedor = new MenuProveedor() { Location = new Point(0,0) };
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(proveedor);
            BtnBack.Visible = false;

        }

        /// <summary>
        ///  Boton de Tienda
        /// </summary>


        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButtonProducto(BtnCamaron, RGBColors.color1);

            carrito.Proveedor = "Tienda";
            carrito.Usuario = Usuario;
            carrito.Fecha = Fecha;

            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(carrito);
            ShowBtnProducto();

            BtnNuevoFolio.Visible = false;
            BtnBack.Visible = true;
            BtnTienda.Location = new Point(2, 3);
            BtnCamaron.Location = new Point(2, 73);
            BtnPescado.Location = new Point(2, 151);
            BtnOtros.Location = new Point(2, 231);

            this.Back += new BackDelegate(RestartScreen);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
        ////Boton de producto
        ///
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            ProductosConfig producto = new ProductosConfig() { Location = new Point(0, 0) };
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(producto);
            BtnBack.Visible = false;
        }


        /// <summary>
        /// Boton Nuevo Folio
        /// </summary
        /// 
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProvedorShowDialog showDialog = new ProvedorShowDialog()
            {
                Usuario = Usuario,
                Fecha = Fecha

            };
            showDialog.loadProveedor += new ProvedorShowDialog.loadProveedorDelegate(ProveedoresLoad);
            showDialog.ShowDialog();
            ShowBtnProducto();

            BtnTienda.Visible = false;
            BtnBack.Visible = true;
            BtnNuevoFolio.Location = new Point(2, 3);
            BtnCamaron.Location = new Point(2, 73);
            BtnPescado.Location = new Point(2, 151);
            BtnOtros.Location = new Point(2, 231);

            this.Back += new BackDelegate(RestartScreen);
            ActivateButtonProducto(BtnCamaron, RGBColors.color1);
        }

        private void MenuUser_Back()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Boton Regresar
        /// </summary>

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Back();
        }






        /// ////////////////////////////////////// Animaciones de Navegacion ///////////////////////////////////////////


        private IconButton currentBtn;
        private Button CurrentBtnProduct;
        private Panel leftBorderBtn;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(82, 122, 242);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(82, 122, 242);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        /// <summary>
        /// 
        /// Ficha de entradas
        /// 
        /// </summary>

   
        public void ProveedoresLoad(string proveedor,string usuario,string fecha)
        {
            carrito.Proveedor = proveedor;
            carrito.Usuario = usuario;
            carrito.Fecha = fecha;

            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(carrito);
            ShowBtnProducto();
            BtnBack.Visible = true;
            this.Back += new BackDelegate(RestartScreen);
        }
     

       
        private void MenuAdmin_Move(object sender, EventArgs e)
        {
            this.Location = new Point(277,44);
        }

        private void ShowBtnProducto()
        {
            BtnSesion.Visible = false;
            BtnInventario.Visible = false;
            BtnProveedor.Visible = false;
            BtnFolios.Visible = false;

            BtnCamaron.Visible = true;
            BtnPescado.Visible = true;
            BtnOtros.Visible = true;
        }
        private void RestartScreen()
        {

            ActivateButton(BtnFolios, RGBColors.color1);
            FichaEntradaAdd();

            BtnNuevoFolio.Location = new Point(2, 73);
            BtnTienda.Location = new Point(2, 151);

            BtnTienda.Visible = true;
            BtnNuevoFolio.Visible = true;
            BtnFolios.Visible = true;
            BtnSesion.Visible = true;
            BtnInventario.Visible = true;
            BtnProveedor.Visible = true;

            BtnCamaron.Visible = false;
            BtnPescado.Visible = false;
            BtnOtros.Visible = false;
        }


        private void ActivateButtonProducto(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonProducto(color);
                CurrentBtnProduct = (Button)senderBtn;
                CurrentBtnProduct.BackColor = Color.FromArgb(1, 76, 76, 76);
                CurrentBtnProduct.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtnProduct.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtnProduct.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtnProduct.ImageAlign = ContentAlignment.MiddleRight;
                CurrentBtnProduct.ForeColor = color;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButtonProducto(Color color)
        {
            if (CurrentBtnProduct != null)
            {
                CurrentBtnProduct.ForeColor = color;
                CurrentBtnProduct.BackColor = Color.FromArgb(82, 122, 242);
                CurrentBtnProduct.ForeColor = Color.Gainsboro;
                CurrentBtnProduct.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }







        private void BtnFichas_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnInventario_MouseHover(object sender, EventArgs e)
        {


        }

        private void BtnAjustes_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnUser_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fichasEntrada1_Load(object sender, EventArgs e)
        {

        }



        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }
        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void ContainerBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCamaron_Click(object sender, EventArgs e)
        {
            ActivateButtonProducto(sender, RGBColors.color1);
            carrito.CamaronAdd();

        }

        private void BtnPescado_Click(object sender, EventArgs e)
        {
            ActivateButtonProducto(sender, RGBColors.color2);
            carrito.PescadoAdd();
        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {
            ActivateButtonProducto(sender, RGBColors.color3);
            carrito.OtrosAdd();
        }

   
    }
}
