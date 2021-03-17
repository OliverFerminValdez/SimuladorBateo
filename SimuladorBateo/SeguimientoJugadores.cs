using SimuladorBateo.Entidades;
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
        public List<Seguimiento> seguimientos { get; set; } = new List<Seguimiento>();
        public SeguimientoJugadores()
        {
            InitializeComponent();
        }

        private void SeguimientoJugadores_Load(object sender, EventArgs e)
        {
            CargarLista();
            SeguimientoDGV.DataSource = seguimientos.Where(t => t.HITS > 0).ToList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public void CargarLista()
        {
       
            foreach (var item in Simulador.ListaJugadores)
            {
                Seguimiento s = new Seguimiento();
                s.JugadorId = item.JugadorId;
                s.Jugador = item.Jugador;
                s.HITS = item.Hits;
                s.HR = item.HR;
                s.Problema = item.Problema;
                s.Turnos = item.Turnos;
                s.AVG = item.Promedio;
                seguimientos.Add(s);
            }
        }
    }
}
