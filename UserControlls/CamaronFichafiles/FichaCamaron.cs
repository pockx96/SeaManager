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

namespace MarDeCortezDsk.UserControlls
{
    public partial class FichaCamaron : UserControl
    {
        public FichaCamaron()
        {
            InitializeComponent();
            ContainerLocations();
            PresentacionAdd();

        }



        /*Datos de la ficha*/
        public string TipoCamaron { get; set; }
        public string PresentacionCamaron { get; set; }
        public string MedidaCamaron { get; set; }
        public int KilosCantidadCamaron  { get; set; }

     

        /* Contenedores */

       /* public MedidasCamaronCultivo CultivoContainer = new MedidasCamaronCultivo();

        public MedidasCamaronCosta CostaContainer = new MedidasCamaronCosta();*/

       /* public PresentacionCamaron PresentacionContainer = new PresentacionCamaron();*/
        


        /* BOTONES */

        private void bttn_addprdct_Click(object sender, EventArgs e)
        {

            
            Conections Oconections = new Conections();

            if (DatosChequed())
            {
                try
                {
                    Oconections.PostfichaTEMP(TipoCamaron, MedidaCamaron, KilosCantidadCamaron);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }

            }


        }

        private void BtnMedidaSearch_Click(object sender, EventArgs e)
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
        private void BtnPresentacion_Click(object sender, EventArgs e)
        {
            PresentacionAdd();

        }

        /* RADIO BUTTON */

        private void RbtnTipoCultivo_CheckedChanged(object sender, EventArgs e)
        {
            MedidaCultivoAdd();

        }

        private void RbtnTipoCosta_CheckedChanged(object sender, EventArgs e)
        {
            MedidaCostaAdd();
        }

        /* METODOS */


        private void ContainerLocations()
        {
            CultivoContainer.Location = new Point(283, 57);
            CostaContainer.Location = new Point(283, 57);
            PresentacionContainer.Location = new Point(283, 57);
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

      
        private bool DatosChequed()
        {

            if (TipoCamaronChequed() && PresentacionChequed() && MedidaChequed() && CantidadChequed())
            {
                MessageBox.Show(TipoCamaron);
                MessageBox.Show(PresentacionCamaron);
                MessageBox.Show(MedidaCamaron);
                MessageBox.Show(Convert.ToString(KilosCantidadCamaron));
                return true;

            }
            else
            {
                return false;
            }
          
        }

        /// <summary>
        /// 
        /// CONTENEDORES 
        /// 
        /// </summary>

        private void MedidaCostaAdd()
        {
            /* METODO POR ADICION Y ELIMINACION
             * CamaronContainer.Controls.Remove(CultivoContainer);
            CamaronContainer.Controls.Remove(PresentacionContainer);
            CamaronContainer.Controls.Add(CostaContainer);*/

            CultivoContainer.Hide();
            PresentacionContainer.Hide();
            CostaContainer.Show();


        }
        private void MedidaCultivoAdd()
        {
            /*METODO POR ADICION Y ELIMINACION
             * 
            CamaronContainer.Controls.Remove(CostaContainer);
            CamaronContainer.Controls.Remove(PresentacionContainer);
            CamaronContainer.Controls.Add(CultivoContainer);*/

            CostaContainer.Hide();
            PresentacionContainer.Hide();
            CultivoContainer.Show();

        }
        private void PresentacionAdd()
        {
            /* METODO POR ADICION Y ELIMINACION

            CamaronContainer.Controls.Remove(CultivoContainer);
            CamaronContainer.Controls.Remove(CostaContainer);
            CamaronContainer.Controls.Add(PresentacionContainer);*/

            CultivoContainer.Hide();
            CostaContainer.Hide();
            PresentacionContainer.Show();
        }


        /* TRASH */

        private void CamaronContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CostaContainer_Load(object sender, EventArgs e)
        {
            TxtBoxPresentacion.Text = PresentacionCamaron;
            TxtboxCantidad.Text = Convert.ToString(KilosCantidadCamaron);
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void CultivoContainer_Load(object sender, EventArgs e)
        {
            TxtBoxPresentacion.Text = PresentacionCamaron;
            TxtboxCantidad.Text = Convert.ToString(KilosCantidadCamaron);
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void PresentacionContainer_Load(object sender, EventArgs e)
        {
            TxtBoxPresentacion.Text = PresentacionCamaron;
            TxtboxCantidad.Text = Convert.ToString(KilosCantidadCamaron);
            TxtboxMedida.Text = MedidaCamaron;
        }

        /// <summary>
        /// 
        /// BOTONES DE PRESENTACION
        /// 
        /// </summary>


        private void BtnMaqueta2k_Click_1(object sender, EventArgs e)
        {
            PresentacionCamaron = "Maqueta 2KG";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;

        }

        private void BtnMaqueta5k_Click(object sender, EventArgs e)
        {
            PresentacionCamaron = "Maqueta 5KG";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;

        }

        private void BtnKileado_Click(object sender, EventArgs e)
        {
            PresentacionCamaron = "Kileado";
            LblCantidad.Text = "Kilos";
            TxtBoxPresentacion.Text = PresentacionCamaron;

        }

        private void BtnVacio_Click(object sender, EventArgs e)
        {
            PresentacionCamaron = "Al vacio";
            LblCantidad.Text = "Cantidad";
            TxtBoxPresentacion.Text = PresentacionCamaron;

        }

        /// <summary>
        ///
        /// BOTONES CULTIVO
        ///
        /// </summary>

        private void BtnU_15_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "U/15";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn16_20_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "16/20";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn21_25_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "21/25";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn26_30_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "26/30";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn31_35_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "21/35";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn36_40_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "36/40";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn41_50_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "41/50";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void Btn51_60_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "51/60";
            TxtboxMedida.Text = MedidaCamaron;

        }

        /// <summary>
        /// BOTONES COSTA
        /// </summary>


        private void BtnU_8_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "U/8";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void BtnU_10_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "U/10";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void BtnU_12_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "U/12";            
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "U/15";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "16/20";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "21/25";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "26/30";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void BtnSs_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "SS";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void BtnCokt_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "Cokt";
            TxtboxMedida.Text = MedidaCamaron;

        }

        private void BtnBait_Click(object sender, EventArgs e)
        {
            MedidaCamaron = "Bait";
            TxtboxMedida.Text = MedidaCamaron;


        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            
            Conections Oconections = new Conections();

            if (DatosChequed())
            {

                try
                {
                    Oconections.PostfichaTEMP(TipoCamaron, MedidaCamaron, KilosCantidadCamaron);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de coneccion con la base de datos");
                }
            }
            else
            {
               MessageBox.Show("Rellena todos los campos");

            }

        }

        private void FichaCamaron_Load(object sender, EventArgs e)
        {
            RbtnTipoCultivo.Checked = true;
        }
    }
}
