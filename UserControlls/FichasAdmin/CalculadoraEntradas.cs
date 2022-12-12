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
using MarDeCortezDsk.UserControlls.FichasConfirmacion;

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class CalculadoraEntradas : UserControl
    {
        public CalculadoraEntradas()
        {
            InitializeComponent();
            IconCenterLeft.Hide();
            IconCenterLeft.Enabled = false;
            IconLeft.Show();
            IconLeft.Enabled = false;
            IconCenterRight.Hide();
            IconCenterRight.Enabled = false;
            IconRight.Show();
            IconRight.Enabled = true;


        }

        /// <summary>
        /// 
        /// Tablas de Producto
        /// 
        /// </summary>

        public FichaEntrada Ficha = new FichaEntrada();
        public List<Camaron> ListCamaron = new List<Camaron>();
        public List<Pescado> ListPescado = new List<Pescado>();
        public List<Pescado> ListOtros = new List<Pescado>();



        public CamaronDatagrid fichaCamaron = new CamaronDatagrid();
        public PescadoDatagrid fichaPescado = new PescadoDatagrid();
        public OtrosDatagrid fichaOtros = new OtrosDatagrid();

        private void CalculadoraEntradas_Load(object sender, EventArgs e)
        {
            fichaCamaron.CargaCamaron(ListCamaron);
            fichaPescado.CargaPescado(ListPescado);
            fichaOtros.CargaOtros(ListOtros);

            CamaronAdd();
        }


        Bitmap PescadoICon = Properties.Resources.fish_white;
        Bitmap CamaronICon = Properties.Resources.shrimp_white;
        Bitmap OtrosICon = Properties.Resources.mussel_white;
        public int FichaState { get; set; }

        public void LoadData(List<Camaron> camaronList, List<Pescado> pescadoList, List<Pescado> otrosList)
        {
            ListCamaron = camaronList;
            ListPescado = pescadoList;
            ListOtros = otrosList;
        }


        private void CamaronAdd()
        {
            FichasContainer.Controls.Remove(fichaPescado);
            FichasContainer.Controls.Remove(fichaOtros);
            FichasContainer.Controls.Add(fichaCamaron);
            IconFicha.Image = CamaronICon;
            LblFicha.Text = "Camaron";
            IconLeft.IconColor = Color.Silver;
            IconCenterRight.IconColor = Color.Silver;
        }
        private void PescadoAdd()
        {
            FichasContainer.Controls.Remove(fichaCamaron);
            FichasContainer.Controls.Remove(fichaOtros);
            FichasContainer.Controls.Add(fichaPescado);
            IconFicha.Image = PescadoICon;
            LblFicha.Text = "Pescado";
            IconLeft.IconColor = Color.White;
            IconCenterRight.IconColor = Color.White;
        }
        private void OtrosAdd()
        {
            FichasContainer.Controls.Remove(fichaCamaron);
            FichasContainer.Controls.Remove(fichaPescado);
            FichasContainer.Controls.Add(fichaOtros);
            IconFicha.Image = OtrosICon;
            LblFicha.Text = "Otros";
            IconLeft.IconColor = Color.Silver;
            IconCenterRight.IconColor = Color.White;
        }

        private void IconCenterLeft_Click(object sender, EventArgs e)
        {
            CamaronAdd();
            IconCenterLeft.Hide();
            IconCenterLeft.Enabled = false;
            IconLeft.Show();
            IconLeft.Enabled = false;
            IconCenterRight.Hide();
            IconCenterRight.Enabled = false;
            IconRight.Show();
            IconRight.Enabled = true;
        }
        private void IconCenterRight_Click(object sender, EventArgs e)
        {
            OtrosAdd();
            IconCenterRight.Hide();
            IconCenterRight.Enabled = false;
            IconRight.Show();
            IconRight.Enabled = false;
            IconCenterLeft.Hide();
            IconCenterLeft.Enabled = false;
            IconLeft.Show();
            IconLeft.Enabled = true;

        }

        private void IconRight_Click(object sender, EventArgs e)
        {
            PescadoAdd();
            IconRight.Hide();
            IconRight.Enabled = false;
            IconCenterRight.Show();
            IconCenterRight.Enabled = true;
            IconLeft.Hide();
            IconLeft.Enabled = false;
            IconCenterLeft.Show();
            IconCenterLeft.Enabled = true;
        }


        private void IconLeft_Click(object sender, EventArgs e)
        {
            PescadoAdd();
            IconLeft.Hide();
            IconLeft.Enabled = false;
            IconCenterLeft.Show();
            IconCenterLeft.Enabled = true;
            IconCenterRight.Show();
            IconCenterRight.Enabled = true;
            IconRight.Hide();
            IconRight.Enabled = false;
        }
    }
}
