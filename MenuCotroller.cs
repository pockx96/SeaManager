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
    public partial class MenuCotroller : Form
    {
        public MenuCotroller()
        {
            InitializeComponent();
        }

        private void bttn_opc_Click(object sender, EventArgs e)
        {
            pnl_alertLogout.Visible = true;
            pnl_alertLogout.Location = new Point(255, 39);
        }

        private void bttn_invent_Click(object sender, EventArgs e)
        {
            Form invent = new inventarios();
            invent.Show();
            this.Close();
        }

        private void bttn_fichasp_Click(object sender, EventArgs e)
        {
            Form fichas = new Fichas();
            fichas.Show();
            this.Close();
        }

        private void bttn_listprvdrs_Click(object sender, EventArgs e)
        {
            Form prvdrs = new ListProvedores();
            prvdrs.Show();
            this.Close();
        }

        private void bttn_acptLogout_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Close();
        }

        private void bttn_cnclLogout_Click(object sender, EventArgs e)
        {
            pnl_alertLogout.Visible = false;
            pnl_alertLogout.Location = new Point(805, 155);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lb_timecll_Click(object sender, EventArgs e)
        {

        }

        private void MenuCotroller_Load(object sender, EventArgs e)
        {

        }
        void _datatime()
        {
            DateTime date = DateTime.Today;
            lb_timecll.Text = (Convert.ToString(date.ToShortTimeString()));
            lb_datacll.Text = (Convert.ToString(date.ToShortDateString()));
        }
    }
}
