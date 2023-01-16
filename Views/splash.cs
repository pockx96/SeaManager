using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.Views
{
    public partial class splash : Form
    {
        public splash(string _Usuario, bool _ItsAdmin)
        {
            InitializeComponent();
            // Establecer la propiedad FormBorderStyle en None para ocultar los bordes del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            progressBar1.ForeColor = Color.Blue;
            progressBar1.BackColor = Color.Yellow;
            this.Usuario = _Usuario;
            this.ItsAdmin = _ItsAdmin;
            if (ItsAdmin)
            {
                MenuAdmin = new MenuAdmin(Usuario);
            }
            else
            {
                MenuUser = new MenuUser(Usuario);
            }
        }
        Timer tmr;
        string Usuario { get; set; }
        bool ItsAdmin { get; set; }

        MenuAdmin MenuAdmin;
        MenuUser MenuUser;
        private void splash_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Opacity = 0.80;
            


            tmr = new Timer();
            //Establecer el intervalo de tiempo en segundos para cerrar el formulario
            tmr.Interval = 5000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();


            progressBar1.Maximum = tmr.Interval;
            progressBar1.Step += 2000;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                //Detener el temporizador
                tmr.Stop();
                //Cerrar el formulario
                if (ItsAdmin)
                {
                    MenuAdmin.Show();
                }
                else
                {
                    MenuUser.Show();
                }
                Close();
            }
            else
            {
                progressBar1.PerformStep();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Crear un objeto GraphicsPath y asignarlo a la propiedadRegion del formulario
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
