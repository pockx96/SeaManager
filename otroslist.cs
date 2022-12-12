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
    public partial class otroslist : Form
    {
        void _restauring() {
            gpbx_datao.Enabled = true;
            pnl_otherlist.Visible = false;
        }
        public otroslist()
        {
            InitializeComponent();
        }

        private void bttn_srch1_Click(object sender, EventArgs e)
        {
            pnl_otherlist.Visible = true;
            gpbx_datao.Enabled = false;
        }

        private void bttn_cntntMedida1_Click(object sender, EventArgs e)
        {
            lb_nmo.Text = bttn_cntntMedida1.Text;
            _restauring();
        }
        private void bttn_cntntMedida2_Click(object sender, EventArgs e)
        {
            lb_nmo.Text = bttn_cntntMedida2.Text;
            _restauring();
        }
        private void bttn_cntntMedida3_Click(object sender, EventArgs e)
        {
            lb_nmo.Text = bttn_cntntMedida3.Text;
            _restauring();
        }

        private void bttn_cntntMedida4_Click(object sender, EventArgs e)
        {
            lb_nmo.Text = bttn_cntntMedida4.Text;
            _restauring();
        }

        private void bttn_cntntMedida5_Click(object sender, EventArgs e)
        {
            lb_nmo.Text = bttn_cntntMedida5.Text;
            _restauring();
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_addprdct_Click(object sender, EventArgs e)
        {
            Conections Oconections = new Conections();
            try
            {
                Oconections.PostfichaTEMP(lb_nmo.Text,"otros", Convert.ToInt32(txtbox_cantidad.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }
    }
}
