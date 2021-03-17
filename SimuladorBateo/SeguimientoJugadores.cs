using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorBateo
{
    public partial class SeguimientoJugadores : Form
    {
        public SeguimientoJugadores()
        {
            InitializeComponent();
        }

        private void SeguimientoJugadores_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SeguimientoDGV.DataSource = Simulador.ListaJugadores.Where(t => t.Turnos > 0).ToList();
        }
    }
}
