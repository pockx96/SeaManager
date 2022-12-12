using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.UserControlls.CamaronFicha
{
    public partial class PresentacionCamaron : UserControl
    {
        public PresentacionCamaron()
        {
            InitializeComponent();
        }

        public string presentacion { get; set; }

        public void BtnKileado_Click(object sender, EventArgs e)
        {
            presentacion = BtnKileado.Text;

        }
        public void bttn_cntntMedida1_Click(object sender, EventArgs e)
        {
            presentacion = BtnMaqueta2k.Text;
        }
        public void BtnMaqueta5k_Click(object sender, EventArgs e)
        {
            presentacion = BtnMaqueta5k.Text;

        }
        public void BtnVacio_Click(object sender, EventArgs e)
        {
            presentacion = BtnVacio.Text;

        }


        /* TRASH */
        private void MedidasGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MedidasGroupBox_Enter_1(object sender, EventArgs e)
        {

        }

    }
}
