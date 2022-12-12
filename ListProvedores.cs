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
    public partial class ListProvedores : Form
    {
        public ListProvedores()
        {
            InitializeComponent();
        }

        private void ListProvedores_Load(object sender, EventArgs e)
        {
            Conections conn = new Conections();
            dataGridView1.DataSource = conn.GetProveedores();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            Form back = new MenuCotroller();
            this.Close();
            back.Show();
        }
    }
}
