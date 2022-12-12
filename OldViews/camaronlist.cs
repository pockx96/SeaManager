using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk
{
    
    public partial class camaronlist : Form
    {
        

        //metodos

        void _ocultar() {

            pnl_MqtaCamaron.Visible = false;
            gpbx_content.Enabled = true;

        }

        public camaronlist()
        {
            InitializeComponent();
        }




        private void camaronlist_Load(object sender, EventArgs e)
        {

        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CHEKEDS
        private void bttn_addprdct_Click(object sender, EventArgs e)
        {
            Conections Oconections = new Conections();
            try
            {
                Oconections.PostfichaTEMP(tipocamaron(), lb_tipo.Text, Convert.ToInt32(txtbox_cantidad.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }
        public string tipocamaron ()
        {
            string tipo;

            if (rdbttn_tpCosta.Checked == true)
            {
               tipo  = "Camaron "+rdbttn_tpCosta.Text;
            }
            else
            {
                tipo = "Camaron " + rdbtt_tpCultivo.Text;
            }
            return tipo;
        }
        private void rdbtt_tpCultivo_CheckedChanged(object sender, EventArgs e)
        {

        }
        //
        private void rdbttn_tpCosta_CheckedChanged(object sender, EventArgs e)
        {

          
            
        }

        private void bttn_listtip_Click(object sender, EventArgs e)
        {
            pnl_MqtaCamaron.Visible = true;
            gpbx_content.Enabled = false;
        }
        //lista de botones maqueta
        private void bttn_cntntMedida1_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida1.Text;
            _ocultar();
        }
        private void bttn_cntntMedida2_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida2.Text;
            _ocultar();
        }
        private void bttn_cntntMedida3_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida3.Text;
            _ocultar();
        }
        private void bttn_cntntMedida4_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida4.Text;
            _ocultar();
        }
        private void bttn_cntntMedida5_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida5.Text;
            _ocultar();
        }
        private void bttn_cntntMedida6_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida6.Text;
            _ocultar();
        }
        private void bttn_cntntMedida7_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida7.Text;
            _ocultar();
        }
        private void bttn_cntntMedida8_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida8.Text;
            _ocultar();
        }
        private void bttn_cntntMedida9_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida9.Text;
            _ocultar();
        }
        private void bttn_cntntMedida10_Click(object sender, EventArgs e)
        {
            lb_tipo.Text = bttn_cntntMedida10.Text;
            _ocultar();
        }

        private void CamaronForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
