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
    public partial class MedidasCamaronCosta : UserControl
    {
        public MedidasCamaronCosta()
        {
            InitializeComponent();
        }

        public string MedidaCosta { get; set; }

        public void BtnU_8_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnU_8.Text;

        }

        public void BtnU_10_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnU_10.Text;
        }

        public void BtnU_12_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnU_12.Text;
        }

        public void BtnU_15_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnU_15.Text;
        }

        public void Btn16_20_Click(object sender, EventArgs e)
        {
            MedidaCosta = Btn16_20.Text;
        }

        public void Btn21_25_Click(object sender, EventArgs e)
        {
            MedidaCosta = Btn21_25.Text;
        }

        public void Btn26_30_Click(object sender, EventArgs e)
        {
            MedidaCosta = Btn26_30.Text;
        }

        public void BtnSs_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnSs.Text;
        }

        public void BtnCokt_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnCokt.Text;
        }

        public void BtnBait_Click(object sender, EventArgs e)
        {
            MedidaCosta = BtnBait.Text;
        }
    }
}
