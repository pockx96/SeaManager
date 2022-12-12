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
    public partial class BarraUsuario : UserControl
    {
        public BarraUsuario()
        {
            InitializeComponent();
        }

        private void BarraUsuario_Load(object sender, EventArgs e)
        {

        }

        public void Title(string name)
        {
            LblUser.Text = name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
