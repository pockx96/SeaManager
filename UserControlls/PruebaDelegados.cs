using MarDeCortezDsk.Views;
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
    public partial class PruebaDelegados : Pruebas_de_metodos
    {
        public delegate void evento();



        public PruebaDelegados()
        {
            InitializeComponent();

        }

        public delegate void pasar();

        public event pasar pasado;


        private void PruebaDelegados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasado();
        }
    }
}
