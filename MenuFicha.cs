using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.UserControlls;

namespace MarDeCortezDsk
{
    public partial class MenuFicha : Form
    {
        //metodos
        Form meelcc = new MenuElecc();
        string proveerdor { get; set; }
        Color HoverColor = new Color();
        public PescadoFicha pescado = new PescadoFicha();
        public FichaCamaron camaron = new FichaCamaron();
        public OtrosFicha otros = new OtrosFicha();

        public MenuFicha(string proveerdor)
        {

            InitializeComponent();
            this.proveerdor = proveerdor;
            HoverColor = Color.OldLace;

        }

        private void MenuFicha_Load(object sender, EventArgs e)
        {

            lb_nametemp.Text = proveerdor;
            camaron.Location = new Point(25, 140);
            PanelForm.Controls.Remove(pescado);
            PanelForm.Controls.Remove(otros);
            PanelForm.Controls.Add(camaron);

            Conections con = new Conections();
            con.DeletefichaTEMP();
            refresh();

        }

        private void refresh()
        {
            Conections conn = new Conections();
            ListaEntrada.DataSource = conn.GetFichasTemp();
        }


        private void btt_Shrim_Click(object sender, EventArgs e)
        {
            refresh();
            camaron.Location = new Point(25, 140);
            PanelForm.Controls.Remove(pescado);
            PanelForm.Controls.Remove(otros);
            PanelForm.Controls.Add(camaron);
        }

        private void bttn_fish_Click(object sender, EventArgs e)
        {
            refresh();
            pescado.Location = new Point(25, 140);
            PanelForm.Controls.Remove(camaron);
            PanelForm.Controls.Remove(otros);
            PanelForm.Controls.Add(pescado);

        }

        private void bttn_other_Click(object sender, EventArgs e)
        {
            otros.Location = new Point(25, 140);
            PanelForm.Controls.Remove(pescado);
            PanelForm.Controls.Remove(camaron);
            PanelForm.Controls.Add(otros);

        }


        private void bttn_cancel_Click(object sender, EventArgs e)
        {


        }

        private void btt_enviar_Click(object sender, EventArgs e)
        {
            //metodo de alert de datos
           
            Conections conn = new Conections();
            Enviodatos();
            conn.DeletefichaTEMP();

        }

        private void dtGvw_Ficha_Temp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void Enviodatos ()
        {
            DateTime date = DateTime.Today;
            string dateString = Convert.ToString(date.ToShortDateString());
            Conections conn = new Conections();
            List<fichaTEMP> ficha = new List<fichaTEMP>();
            ficha = conn.GetFichasTemp();

            foreach (fichaTEMP element in ficha) 
            {

                conn.Postficha(element.Nombre, element.Tipo, element.Cantidad, dateString);
            }

        }

        private void lb_nametemp_Click(object sender, EventArgs e)
        {

        }

        private void BanerInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_ficha_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btt_Shrim_MouseHover(object sender, EventArgs e)
        {
            /*btt_Shrim.BackColor = HoverColor;*/
        }

        private void bttn_fish_MouseHover(object sender, EventArgs e)
        {
            /*bttn_fish.BackColor = HoverColor;*/

        }

        private void bttn_other_MouseHover(object sender, EventArgs e)
        {
            /*bttn_other.BackColor = HoverColor;*/

        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuFicha_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Conections conn = new Conections();
            Enviodatos();
            conn.DeletefichaTEMP();

        }
    }
}
