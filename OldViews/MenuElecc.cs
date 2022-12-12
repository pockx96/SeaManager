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
    public partial class MenuElecc : Form
    {

        //metodos
        int info = 0;

        void _datatime() {
            DateTime date = DateTime.Today;
            lb_time.Text = (Convert.ToString(date.ToShortTimeString()));
            lb_data.Text = (Convert.ToString(date.ToShortDateString()));
        }
        public MenuElecc()
        {
            InitializeComponent();
            //nms = txtbox_nmPrvdr.Text;
        }
        private void MenuElecc_Load(object sender, EventArgs e)
        {
            _datatime();

        }

        //cerrar sesion
        private void bttn_logout_Click(object sender, EventArgs e)
        {
            _datatime();
            pnl_alertLogout.Visible = true;
            pnl_alertLogout.Location = new Point(312, 232);
            bttn_prvdr.Enabled = false;
            bttn_tnda.Enabled = false;
            bttn_info.Enabled = false;
        }

        private void bttn_info_Click(object sender, EventArgs e)
        {
            info = info + 1;
            if (info == 1)
            {
                pnl_info.Visible = true;
                pnl_info.Location = new Point(6, 16);
            }
            if (info == 2)
            {
                pnl_info.Visible = false;
                pnl_info.Location = new Point(289, 113);
                info = 0;
            }

        }

        //botones de alertlogout

        private void bttn_cnclLogout_Click(object sender, EventArgs e)
        {
            _datatime();
            pnl_alertLogout.Visible = false;
            pnl_alertLogout.Location = new Point(913, 248);
            bttn_prvdr.Enabled = true;
            bttn_tnda.Enabled = true;
            bttn_info.Enabled = true;
        }

        private void bttn_acptLogout_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Close();
        }
        
       

        //panel agregar Provedor
        private void bttn_prvdr_Click(object sender, EventArgs e)
        {
            _datatime();
            pnl_addprvdr.Visible = true;
            pnl_addprvdr.Location = new Point(113, 240);
            bttn_info.Enabled = false;
            bttn_logout.Enabled = false;
        }

        private void bttn_cnclAddprvdr_Click(object sender, EventArgs e)
        {
            _datatime();
            pnl_addprvdr.Visible = false;
            pnl_addprvdr.Location = new Point(454, 541);
            bttn_info.Enabled = true;
            bttn_logout.Enabled = true;
        }


        // autorizacion ficha
        private void bttn_tnda_Click(object sender, EventArgs e)
        {
            _datatime();
            Form ficha = new MenuFicha("Tienda");
            ficha.Show();
            this.Close();
        }

        private void bttn_acptAddprvdr_Click(object sender, EventArgs e)
        {
            _datatime();
            string idProveedor = TxtIdProveedor.Text;
            string NombreProveedor = txtbox_nmPrvdr.Text;
            string TelefonoProveedor = txtbox_telPrvdr.Text;

            Form ficha = new MenuFicha(NombreProveedor);
            Conections conn = new Conections();
            conn.PostProveedores(idProveedor,NombreProveedor,TelefonoProveedor);
            
            ficha.Show();
            this.Hide();
        }

        private void pnl_addprvdr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_borderup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
