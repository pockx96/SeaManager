using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.UserControlls
{
    public partial class MedidasCamaronCultivo : UserControl
    {
        public MedidasCamaronCultivo()
        {
            InitializeComponent();
        }

        public string MedidaCultivo { get; set; }

        private void BtnU_15_Click(object sender, EventArgs e)
        {
            MedidaCultivo = BtnU_15.Text;

        }

        private void Btn16_20_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn16_20.Text;
        }

        private void Btn21_25_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn21_25.Text;
        }

        private void Btn26_30_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn26_30.Text;
        }

        private void Btn31_35_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn31_35.Text;
        }

        private void Btn36_40_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn36_40.Text;
        }

        private void Btn41_50_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn41_50.Text;
        }

        private void Btn51_60_Click(object sender, EventArgs e)
        {
            MedidaCultivo = Btn51_60.Text;
        }

        private void MedidasGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
