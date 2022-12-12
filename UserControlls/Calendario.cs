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
    public partial class Calendario : UserControl
    {
        public Calendario()
        {
            InitializeComponent();
        }

        public string Fecha { get; set; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            Fecha = DateToday;
            LblFecha.Text = DateToday;

        }
    }
}
