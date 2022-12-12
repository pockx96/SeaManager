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
    public partial class MenuEleccion : Form
    {
        public MenuEleccion()
        {
            InitializeComponent();
        }

        private void MenuEleccion_Load(object sender, EventArgs e)
        {
            _horadata();
        }



        void _horadata() {
            lb_time.Text = (dtTmpct_datatime.Value.Hour + " : " + dtTmpct_datatime.Value.Minute).ToString();
            lb_data.Text = (dtTmpct_datatime.Value.Day + " / " + dtTmpct_datatime.Value.Month + " / " + dtTmpct_datatime.Value.Year).ToString();
        }


        private void bttn_provdr_Click_1(object sender, EventArgs e)
        {
            _horadata();
            pnl_registroProveedor.Visible = true;
            pnl_registroProveedor.Location = new Point(12, 515);
        }

        private void bttn_tnda_Click(object sender, EventArgs e)
        {
            _horadata();
            Form btaficha = new MenuFicha();
            this.Hide();
            btaficha.Show();
        }

        private void bttn_LogOut_Click(object sender, EventArgs e)
        {
            pnl_verifity.Visible = true;
            pnl_verifity.Location = new Point(388, 213);
        }

        private void bttn_acept_Click(object sender, EventArgs e)
        {
            this.Close();
            Form bttalogout = new Login();
            bttalogout.Show();
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            pnl_verifity.Visible = false;
            pnl_verifity.Location = new Point(909, 519);
        }

        private void bttn_aceptregistr_Click(object sender, EventArgs e)
        {
            Form btaficha = new MenuFicha();
            this.Hide();
            btaficha.Show();
        }

        private void bttn_cancelregistr_Click(object sender, EventArgs e)
        {
            pnl_registroProveedor.Visible = false;
            pnl_registroProveedor.Location = new Point(17, 540);
        }

        private void bttn_busqPrvdr_Click(object sender, EventArgs e)
        {
            //busqueda de provedores registrados
        }
    }
}
