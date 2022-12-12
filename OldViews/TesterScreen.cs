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
    public partial class TesterScreen : Form
    {
        public TesterScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form teste1 = new MenuElecc();
            teste1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form teste2 = new MenuCotroller();
            teste2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form teste1 = new MenuFicha("test");
            teste1.Show();
        }

        
    }
}
