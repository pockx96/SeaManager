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
    public partial class labelCrear : UserControl
    {
        public labelCrear(string text)
        {
            InitializeComponent();
            this.TextString = text;
        }

        public string TextString { get; set; }

        public delegate void CrearDelegate();
        public event CrearDelegate Crear;
        private void LblCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void labelCrear_Load(object sender, EventArgs e)
        {
            LblCrear.Text = TextString;
        }
    }
}
