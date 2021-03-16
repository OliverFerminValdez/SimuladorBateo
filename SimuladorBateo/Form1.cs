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
    public partial class Simulador : Form
    {

        public int MovPX { get; set; } = 700;
        public int DiaSimulacion { get; set; } = 1;
        public int TotalLanzamientos { get; set; }
        public int ContadorLanzamientos { get; set; }
        //Control de turnos
        public Jugadores JugadorEnTurno { get; set; }
        public static List<Jugadores> ListaJugadores { get; set; } = new List<Jugadores>();

        enum Padecimientos
        {
            Gripe = 1,
            Trasnocho = 2,
            Resaca = 3,
            COVID = 4,
        }
        enum Lanzamientos
        {
            Recta = 1,
            Curva = 2,
            Cambio = 3,
            Nudillo = 4,
            Slider = 5,
        }

        public Simulador()
        {
            InitializeComponent();
        }

        private void Movimiento_Tick(object sender, EventArgs e)
        {
            DiaNUD.Value = DiaSimulacion;
            LanzamientosTotalesNUD.Value = TotalLanzamientos;

            MovPX-=5;

            if (MovPX - 47 <= 180) { MovPX = 700; TotalLanzamientos++; ContadorLanzamientos++; } else
            {
                AntesPB.Visible = false;
                DespuesPB.Visible = true;
            }

            if(MovPX -47 <= 500) {
                DespuesPB.Visible = false;
                AntesPB.Visible = true ;
            }
            
            PelotaPB.SetBounds(MovPX - 47, 92, 49, 38);

            if(ContadorLanzamientos == 5) { ContadorLanzamientos = 0; DiaSimulacion++;  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalLanzamientos++;
            Movimiento.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimiento.Stop();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        public void Iniciar()
        {
            for (int i = 0; i < 20; i++)
            {
                Jugadores j = new Jugadores();
                j.JugadorId = i + 1;
                j.Jugador = "Jugador " + (i + 1);
                ListaJugadores.Add(j);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f = new SeguimientoJugadores();
            f.Show();
        }
    }
}
