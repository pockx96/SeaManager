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
using MarDeCortezDsk.UserControlls.CamaronFicha;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;


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
        /// Datos de la ficha
        /// </summary>
        /// 

        public string TipoCamaron { get; set; }
        public string PresentacionCamaron { get; set; }
        public string MedidaCamaron { get; set; }
        public string Proveedor { get; set; }
        public string Almaecenaje { get; set; }
        public int KilosCantidadCamaron  { get; set; }

        public List<Camaron> ListCamaron = new List<Camaron>();
        public Camaron camaron = new Camaron();
       
        


        /// <summary>
        ///  Locations de los contenedores
        /// </summary>
        /// 

        public Point FormleftLocation = new Point(19, 5);
        public Point FormrighttLocation = new Point(281, 5);
        public Point FormcenterLocation = new Point(130, 3);
        

    

        private void ContainerLocations()
        {
            CostaContainer.Hide();
            CultivoContainer.Hide();
            PresentacionContainer.Hide();
            CultivoContainer.Location = FormrighttLocation;
            CostaContainer.Location = FormrighttLocation;
            PresentacionContainer.Location = FormrighttLocation;
        }





        /// <summary>
        /// 
        ///  VALIDADORES DEL FORMULARIO
        ///  
        /// </summary>

       
        public bool TipoCamaronChequed()
        {
            if (RbtnTipoCosta.Checked == true)
            {
                TipoCamaron = "Camaron Costa";
                return true;
            }
            else if(RbtnTipoCultivo.Checked == true)
            {
                TipoCamaron = "Camaron Cultivo";
                return true;
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un tipo de camaron");
                return false;
            }
        }

        private bool PresentacionChequed()
        {
            if (PresentacionCamaron != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Porfavor Selecciona una Presentacion");
                return false;
            }
        }
        private bool MedidaChequed()
        {
            if (MedidaCamaron != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Porfavor Selecciona una Medida");
                return false;
            }

        }



        private bool CantidadChequed()
        {

            if (TxtboxCantidad.Text !=null )
            {

                try
                {
                    KilosCantidadCamaron = Convert.ToInt32(TxtboxCantidad.Text);
                    return true;

                }
                catch
                {
                    MessageBox.Show("Porfavor digita una cantidad / kilos");
                    return false;
                }

               
            }
            else
            {
                MessageBox.Show("Porfavor digita una cantidad / kilos");
                return false;
            }
        }

      
        public bool DatosChequed()
        {

            if (TipoCamaronChequed() && PresentacionChequed() && MedidaChequed() && CantidadChequed())
            {

                return true;

            }
            else
            {
                return false;
            }
          
        }

        /// <summary>
        /// 
        /// OBTENCION DE DATOS
        /// 
        /// 
        /// </summary>
     

        public Camaron GetCamaronRow(string FichaEntrada ,string Almacenaje)
        {
            camaron.FichaEntrada = FichaEntrada;
            camaron.Tipo_producto = TipoCamaron;
            camaron.Tipo_producto = TipoCamaron;
            camaron.Medida = MedidaCamaron;
            camaron.Almacenaje = Almacenaje;
            camaron.Cantidad = KilosCantidadCamaron;
            camaron.kilos = KilosCantidadCamaron;
            camaron.Presentacion = PresentacionCamaron;
            ListCamaron.Add(camaron);
            return camaron;

        }

        public List<Camaron> GetCamaronList()
        {
            return ListCamaron;
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
    }
}
