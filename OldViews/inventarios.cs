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
    public partial class inventarios : Form
    {
        public inventarios()
        {
            InitializeComponent();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            Form back = new MenuCotroller();
            this.Close();
            back.Show();
        }
    }
}
