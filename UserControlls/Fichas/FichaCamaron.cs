using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;
using CustomMessageBox;


namespace MarDeCortezDsk.UserControlls
{
    public partial class FichaCamaron : UserControl
    {
        public FichaCamaron()
        {
            InitializeComponent();


        }
        private void FichaCamaron_Load(object sender, EventArgs e)
        {
            ContainerLocations();
            RbtnTipoCosta.Checked = true;


        }


        /// <summary>
        /// Datos del formulario
        /// 
        /// </summary>
        /// 

        public string TipoCamaron { get; set; }
        public string PresentacionCamaron { get; set; }
        public string MedidaCamaron { get; set; }
        public string Proveedor { get; set; }
        public string Almaecenaje { get; set; }
        public int KilosCantidadCamaron  { get; set; }




        /// <summary>
        /// 
        /// OBTENCION DE DATOS
        /// 
        /// 
        /// </summary>


        public Camaron GetRow(string Folio, string Almacenaje)
        {
            Camaron camaron = new Camaron();
            CamaronController controller = new CamaronController();
            camaron.FolioEntrada = Folio;
            camaron.Tipo_producto = "Camaron";
            camaron.Presentacion = TxtBoxPresentacion.Text;
            camaron.Medida = TxtboxMedida.Text;
            camaron.Almacenaje = Almacenaje;
            camaron.Cantidad = Convert.ToInt32(TxtboxCantidad.Text);
            camaron.Kilos = KilosCalculation(camaron.Cantidad,camaron.Presentacion);
            return camaron;

        }



        public void Clear()
        {
            TxtBoxPresentacion.Clear();
            TxtboxMedida.Clear();
            TxtboxCantidad.Value = 0;
        }


        /// <summary>
        /// 
        ///  VALIDADORES DEL FORMULARIO
        ///  
        /// </summary>




        public bool ValidationForm()
        {

            if (TxtBoxPresentacion.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione una presentacion.", "Aviso!");
                return false;
            }
            else if (TxtboxMedida.Text == "")
            {
                DialogResult result = RJMessageBox.Show("Por favor seleccione una medida.", "Aviso!");
                return false;
            }
            else if (TxtboxCantidad.Value <=0)
            {
                DialogResult result = RJMessageBox.Show("Por favor ingrese una cantidad.", "Aviso!");
                return false;
            }
            return true;

        }


        /// <summary>
        ///  Contenedores de botones
        /// </summary>
        /// 

        public Point FormleftLocation = new Point(19, 0);
        public Point FormrighttLocation = new Point(308, 0);
        public Point FormcenterLocation = new Point(119, 0);
        

    

        private void ContainerLocations()
        {
            CostaContainer.Hide();
            CultivoContainer.Hide();
            PresentacionContainer.Hide();
            CultivoContainer.Location = FormrighttLocation;
            CostaContainer.Location = FormrighttLocation;
            PresentacionContainer.Location = FormrighttLocation;
            FormularioContainer.Location = FormcenterLocation;
        }





       

     
        /// <summary>
        /// 
        /// CONTENEDORES 
        /// 
        /// </summary>

        private void MedidaCostaAdd()
        {

            FormularioContainer.Location = FormleftLocation;
            CultivoContainer.Hide();
            PresentacionContainer.Hide();
            CostaContainer.Show();

        }
        private void MedidaCultivoAdd()
        {
            FormularioContainer.Location = FormleftLocation;
            CostaContainer.Hide();
            PresentacionContainer.Hide();
            CultivoContainer.Show();

        }
        private void PresentacionAdd()
        {

            FormularioContainer.Location = FormleftLocation;
            CultivoContainer.Hide();
            CostaContainer.Hide();
            PresentacionContainer.Show();

        }



        /// <summary>
        /// 
        /// Botones Lupa
        /// 
        /// </summary>
   
  

    

        private void BtnPresentacionSearch_Click(object sender, EventArgs e)
        {

            PresentacionAdd();
        }

        private void BtnMedidaSearch_Click_1(object sender, EventArgs e)
        {
            if (RbtnTipoCosta.Checked == true)
            {
                MedidaCostaAdd();
            }
            else if (RbtnTipoCultivo.Checked == true)
            {
                MedidaCultivoAdd();
            }
        }

      


        /// <summary>
        /// 
        /// Botones de Presentacion
        /// 
        /// </summary>


        private void BtnMaqueta2k_Click(object sender, EventArgs e)
        {
            PresentacionCamaron = "Maqueta 2KG";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;
            FormularioContainer.Location = FormcenterLocation;
            PresentacionContainer.Hide();

        }


        private void BtnKileado_Click_1(object sender, EventArgs e)
        {
            PresentacionCamaron = "Kileado";
            LblCantidad.Text = "Kilos";
            TxtBoxPresentacion.Text = PresentacionCamaron;
            FormularioContainer.Location = FormcenterLocation;
            PresentacionContainer.Hide();
        }

        private void BtnVacio_Click_1(object sender, EventArgs e)
        {
            PresentacionCamaron = "Al Vacio";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;
            FormularioContainer.Location = FormcenterLocation;
            PresentacionContainer.Hide();
        }

        private void BtnMaqueta5k_Click_1(object sender, EventArgs e)
        {
            PresentacionCamaron = "Maqueta 5KG";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;
            FormularioContainer.Location = FormcenterLocation;
            PresentacionContainer.Hide();

        }

        

        /// <summary>
        /// 
        /// Botones Costa
        /// 
        /// </summary>
        /// 

        private void MedidaAsignament(string title)
        {
            MedidaCamaron = title;
            TxtboxMedida.Text = MedidaCamaron;
            CostaContainer.Hide();
            CultivoContainer.Hide();
            FormularioContainer.Location = FormcenterLocation;
        }


        public float KilosCalculation(int cantidad, string presentacion)
        {
            float kilos;
            switch (presentacion)
            {
                case "Maqueta 2KG":
                    kilos = cantidad * 2;
                    return kilos;
                case "Maqueta 5KG":
                    kilos = cantidad * 5;
                    return kilos;
                case "Al Vacio":
                    kilos = cantidad;
                    return kilos;
                case "Kileado":
                    kilos = cantidad;
                    return kilos;

            }
            return 0;
        }


        private void BtnU_8_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("U/8");
        }

        private void BtnU_10_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("U/10");
        }

        private void BtnU_12_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("U/12");
        }

        private void BtnU_15B_Click(object sender, EventArgs e)
        {
            MedidaAsignament("U/15");
        }

        private void Btn16_20B_Click(object sender, EventArgs e)
        {
            MedidaAsignament("16/20");
        }

        private void Btn21_25B_Click(object sender, EventArgs e)
        {
            MedidaAsignament("21/25");
        }

        private void Btn26_30B_Click(object sender, EventArgs e)
        {
            MedidaAsignament("25/30");
        }

        private void BtnSSB_Click(object sender, EventArgs e)
        {
            MedidaAsignament("SS");
        }

        private void BtnCOKTB_Click(object sender, EventArgs e)
        {
            MedidaAsignament("Cockt");
        }

        private void BtnBait_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("Bait");
        }

      
        /// <summary>
        /// 
        /// Botones Cultivo
        /// 
        /// </summary>

        private void BtnU_15_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("U/15");
        }

        private void Btn16_20_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("16/20");
        }

        private void Btn21_25_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("21/25");
        }

        private void Btn26_30_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("26/30");
        }

        private void Btn31_35_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("31/35");
        }

        private void Btn36_40_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("36/40");
        }

        private void Btn41_50_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("41/50");
        }

        private void Btn51_60_Click_1(object sender, EventArgs e)
        {
            MedidaAsignament("51/60");
        }



        /// <summary>
        /// 
        /// Radio Butons
        /// 
        /// </summary>


        private void RbtnTipoCultivo_CheckedChanged(object sender, EventArgs e)
        {
            TxtboxMedida.Text = "";
        }

        private void RbtnTipoCosta_CheckedChanged(object sender, EventArgs e)
        {
            TxtboxMedida.Text = "";

        }






















        /* TRASH */

        private void CamaronContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtboxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioContainer_Enter(object sender, EventArgs e)
        {

        }

        private void CostaContainer_Enter(object sender, EventArgs e)
        {

        }
    }
}
