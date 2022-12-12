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
    public partial class peceslist : Form
    {
        //metodos
        
        void _ocultarsrch() {
            pnl_listname.Visible = false;
            pnl_listname.Location = new Point(18, 405);
        }
        void _ocultartp()
        {
            pnl_listpresent.Visible = false;
            pnl_listpresent.Location = new Point(264, 34);
        }
        void _desactivebuton() {
            gpbx_datafish.Enabled = false;
        }
        void _activebuton() {
            gpbx_datafish.Enabled = true;
        }

        public peceslist()
        {
            InitializeComponent();
        }

        private void bttn_cancelfish_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bttn_listtip_Click(object sender, EventArgs e)
        {

                pnl_listpresent.Visible = true;
                pnl_listpresent.Location = new Point(6, 45);
            _desactivebuton();

        }

        private void bttn_srch1_Click(object sender, EventArgs e)
        {

                pnl_listname.Visible = true;
                pnl_listname.Location = new Point(18, 37);
            _desactivebuton();


        }

 
        //controladores de lista nombre
        private void bttn_back_Click(object sender, EventArgs e)
        {
            pnl_listpart1.Visible = true;
            pnl_listpart1.Location = new Point(17, 44);
            pnl_listprt2.Visible = false;
            pnl_listprt2.Location = new Point(254, 313);
            
        }

        private void bttn_Next_Click(object sender, EventArgs e)
        {
            pnl_listprt2.Visible = true;
            pnl_listprt2.Location = new Point(21, 42);
            pnl_listpart1.Visible = false;
            pnl_listpart1.Location = new Point(17, 372);
        }

        //lista de botones nombre producto

        private void btt_nmp1_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp1.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp2_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp2.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp3_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp3.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp4_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp4.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp5_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp5.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp6_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp6.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp7_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp7.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp8_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp8.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp9_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp9.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp10_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp10.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp11_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp11.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp12_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp12.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp13_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp13.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp14_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp14.Text;
            _ocultarsrch();
            _activebuton();
        }
        private void btt_nmp15_Click(object sender, EventArgs e)
        {
            lb_nmproduct.Text = btt_nmp15.Text;
            _ocultarsrch();
            _activebuton();
        }

        //lista de botones presentaciones

        private void bttn_prst1_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = bttn_prst1.Text;
            lb_kgorcant.Text = "Cantidad:";
            txtbox_cantidad.Text = "";
            _ocultartp();
            _activebuton();
        }

        private void bttn_prst2_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = "Kileado";
            lb_kgorcant.Text = "Kilogramos:";
            txtbox_cantidad.Text = "";
            _ocultartp();
            _activebuton();
        }

        private void bttn_prst3_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = "Kileado";
            lb_kgorcant.Text = "Kilogramos:";
            txtbox_cantidad.Text = "2";
            _ocultartp();
            _activebuton();
        }

        private void bttn_prst4_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = "Kileado";
            lb_kgorcant.Text = "Kilogramos:";
            txtbox_cantidad.Text = "5";
            _ocultartp();
            _activebuton();
        }

        private void bttn_prst5_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = "Kileado";
            lb_kgorcant.Text = "Kilogramos:";
            txtbox_cantidad.Text = "10";
            _ocultartp();
            _activebuton();
        }

        private void bttn_prst6_Click(object sender, EventArgs e)
        {
            lb_prsnt.Text = bttn_prst6.Text;
            lb_kgorcant.Text = "Cantidad:";
            txtbox_cantidad.Text = "";
            _ocultartp();
            _activebuton();
        }

        private void peceslist_Load(object sender, EventArgs e)
        {

        }

        private void bttn_addprdct_Click(object sender, EventArgs e)
        {

            Conections Oconections = new Conections();
            try
            {
                Oconections.PostfichaTEMP(lb_nmproduct.Text, lb_prsnt.Text, Convert.ToInt32(txtbox_cantidad.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
