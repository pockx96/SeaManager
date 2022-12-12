using MarDeCortezDsk.Controllers;
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

namespace MarDeCortezDsk.UserControlls
{
    public partial class InventarioRestas : UserControl
    {
        public InventarioRestas(Camaron camaron)
        {
            InitializeComponent();
            this._Camaron = camaron;
            this.Update += new UpdateDelegate(UpdateCamaron);
        }

        public InventarioRestas(Pescado pescado)
        {
            InitializeComponent();
            this._Pescado = pescado;
            this.Update += new UpdateDelegate(UpdatePescado);
        }

        Camaron _Camaron { get; set; }
        Pescado _Pescado { get; set; }


        public delegate void UpdateDelegate();
        public event UpdateDelegate Update;

        private void TxtBoxConfirmar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateCamaron()
        {
            CamaronController camaronController = new CamaronController();
            _Camaron.Cantidad = Convert.ToInt32(NumUpDown.Value);
            _Camaron.Kilos = camaronController.KilosCalculation(_Camaron.Cantidad, _Camaron.Presentacion);
            camaronController.Update(_Camaron,false);
        }
        private void UpdatePescado()
        {
            PescadoController pescadoController = new PescadoController();
            pescadoController.Update(_Pescado,false);
        }
    }
}
