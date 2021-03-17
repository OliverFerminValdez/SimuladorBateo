using SimuladorBateo.BLL;
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
        public int ContadorDias { get; set; }
        //Control de lanzamientos
        public Random Lanzamiento { get; set; } = new Random();
        public int TotalLanzamientos { get; set; }
        public int ContadorLanzamientos { get; set; }
        //Control de bateos
        public Random BateoJugador { get; set; } = new Random();
        public bool JugadorBateo { get; set; }
        public Random TipoBateo { get; set; } = new Random();

        //Control de turnos
        public Jugadores JugadorEnTurno { get; set; }
        public static List<Jugadores> ListaJugadores { get; set; } = new List<Jugadores>();

        //Control de padecimientos
        public Random Padecimiento { get; set; } = new Random();
        public bool SeHaEnfermado { get; set; } = false;

        public Simulador()
        {
            InitializeComponent();
        }

        //Duracion de padecimientos = Trasnocho 1 dia, Resaca 1 dia, Gripe 2 dias, COVID 3 dias
        public int ContadorCOVID { get; set; } = 3;
        public int ContadorGripe { get; set; } = 2;
        public int ContadorResaca { get; set; } = 1;
        public int ContadorTrasnocho{ get; set; } = 1;
        public bool PrimeraVez { get; set; }
        public void Actualizar()
        {
            HitsNUD.Value = JugadorEnTurno.Hits;
            HRNUD.Value = JugadorEnTurno.HR;
            FoulsNUD.Value = JugadorEnTurno.Fouls;
            FallosNUD.Value = JugadorEnTurno.Fallos;
            CondicionRTB.Text = JugadorEnTurno.EstadoDeSalud;
            SeHaEnfermado = false;
            ContadorLanzamientos = 0;
            ContadorCOVID = 3;
            ContadorGripe = 2;
            ContadorResaca = 1;
            ContadorTrasnocho = 1;
            DiaSimulacion = 1;

        }

        private void Movimiento_Tick(object sender, EventArgs e)
        {
            
            JugadorLb.Text = JugadorEnTurno.Jugador;
            DiaNUD.Value = DiaSimulacion;
            LanzamientosTotalesNUD.Value = TotalLanzamientos;

            MovPX-=5;

            if (MovPX - 47 <= 180 ) 
            { 
                MovPX = 700; 
                TotalLanzamientos++; 
                TipoLanzamiento();
                JugadorBatea();
                TipoBateoJugador();
                ContadorLanzamientos++;
            } 
            else
            {
                AntesPB.Visible = false;
                DespuesPB.Visible = true;
            }

            if(MovPX -47 <= 500) {
                DespuesPB.Visible = false;
                AntesPB.Visible = true ;
            }
            
            PelotaPB.SetBounds(MovPX - 47, 92, 49, 38);

            if(ContadorLanzamientos == 5) { ContadorDias++; PadecimientoJugador(); ContadorLanzamientos = 0; DiaSimulacion++;  }

            if(ContadorDias == 5) 
            {
                ContadorDias = 0;
                TotalLanzamientos = 0;
                JugadorEnTurno = JugadorBLL.Buscar(JugadorEnTurno.JugadorId + 1);
                Actualizar();
            }
        }
        public void TipoLanzamiento()
        {
            int l = Lanzamiento.Next(1, 6);
            if(l == 1) { LanzamientoTb.Text = "Recta"; }
            if (l == 2) { LanzamientoTb.Text = "Curva"; }
            if (l == 3) { LanzamientoTb.Text = "Cambio"; }
            if (l == 4) { LanzamientoTb.Text = "Nudillo"; }
            if (l == 5) { LanzamientoTb.Text = "Slider"; }
        }
        public void JugadorBatea()
        {
            if(JugadorEnTurno.PrecisionBateo == 0.80)
            {
                int v = BateoJugador.Next(1, 11);
                if(v == 1 || v == 3) 
                { 
                    JugadorBateo = false;    
                } 
                else { JugadorBateo = true; }
            }
            if(JugadorEnTurno.PrecisionBateo == 0.6)
            {
                int v2 = BateoJugador.Next(1, 11);

                if(v2 == 1 || v2 == 2 || v2 == 3 || v2 == 4)
                {
                    JugadorBateo = false;
                }
                else { JugadorBateo = true; }
            }
            if (JugadorEnTurno.PrecisionBateo == 0.50)
            {
                int v3 = BateoJugador.Next(1, 11);

                if (v3 == 1 || v3 == 2 || v3 == 3 || v3 == 4 || v3 == 5)
                {
                    JugadorBateo = false;
                }
                else { JugadorBateo = true; }
            }
        }
        public void TipoBateoJugador()
        {
            int bat = TipoBateo.Next(1,9);
            string tb = "";
            if (!JugadorBateo) { tb = "Fallo"; JugadorEnTurno.Fallos++; FallosNUD.Value = JugadorEnTurno.Fallos; BateoTb.Text = tb; return; }
            if (bat == 1) { tb = "Home run"; JugadorEnTurno.HR++; }
            if (bat == 2) { tb = "Foul"; JugadorEnTurno.Fouls++; }
            if (bat == 3) { tb = "Foul"; JugadorEnTurno.Fouls++; }
            if (bat == 4) { tb = "Home Run"; JugadorEnTurno.HR++; }
            if (bat == 5) { tb = "Hit"; JugadorEnTurno.Hits++; }
            if (bat == 6) { tb = "Hit"; JugadorEnTurno.Hits++; }
            if (bat == 7) { tb = "Hit"; JugadorEnTurno.Hits++; }
            if (bat == 8) { tb = "Hit"; JugadorEnTurno.Hits++; }

            BateoTb.Text = tb;
            HitsNUD.Value = JugadorEnTurno.Hits;
            FoulsNUD.Value = JugadorEnTurno.Fouls;
            HRNUD.Value = JugadorEnTurno.HR;
            //
            JugadorEnTurno.Turnos = TotalLanzamientos;
            JugadorEnTurno.Promedio = Math.Round((double)(JugadorEnTurno.HR + JugadorEnTurno.Hits)/TotalLanzamientos,2);
            PromedioTb.Text = JugadorEnTurno.Promedio.ToString();
        }
        public void PadecimientoJugador()
        {
            if(JugadorEnTurno.EstadoDeSalud != "Esta sano") 
            {
                SeHaEnfermado = true;
                if(JugadorEnTurno.EstadoDeSalud == "Se contagio de gripe") { JugadorEnTurno.Problema = "Se contagio de la gripe";  ContadorGripe--; }
                if (JugadorEnTurno.EstadoDeSalud == "Se trasnocho") { JugadorEnTurno.Problema = "Se trasnocho"; ContadorTrasnocho--; }
                if (JugadorEnTurno.EstadoDeSalud == "Esta resacado") { JugadorEnTurno.Problema = "Tomo mucho alcohol"; ContadorResaca--; }
                if (JugadorEnTurno.EstadoDeSalud == "Se contagio de COVID") { JugadorEnTurno.Problema = "Se contagio de la COVID"; ContadorCOVID--; }

                if (ContadorGripe == 0) { JugadorEnTurno.EstadoDeSalud = "Esta sano";  SeHaEnfermado = true; }
                if (ContadorResaca == 0) { JugadorEnTurno.EstadoDeSalud = "Esta sano"; SeHaEnfermado = true; }
                if (ContadorTrasnocho == 0) { JugadorEnTurno.EstadoDeSalud = "Esta sano"; SeHaEnfermado = true; }
                if (ContadorCOVID == 0) { JugadorEnTurno.EstadoDeSalud = "Esta sano"; SeHaEnfermado = true; }
            }

            if (!SeHaEnfermado)
            {
                int p = Padecimiento.Next(1,14);
                if(p == 1) { JugadorEnTurno.EstadoDeSalud = "Se contagio de gripe"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 2) { JugadorEnTurno.EstadoDeSalud = "Se trasnocho"; JugadorEnTurno.PrecisionBateo = 0.5; }
                if (p == 3) { JugadorEnTurno.EstadoDeSalud = "Se contagio de gripe"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 4) { JugadorEnTurno.EstadoDeSalud = "Se contagio de COVID"; JugadorEnTurno.PrecisionBateo = 0.50; }
                if (p == 5) { JugadorEnTurno.EstadoDeSalud = "Se contagio de COVID"; JugadorEnTurno.PrecisionBateo = 0.50; }
                if (p == 6) { JugadorEnTurno.EstadoDeSalud = "Esta resacado"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 7) { JugadorEnTurno.EstadoDeSalud = "Se contagio de gripe"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 8) { JugadorEnTurno.EstadoDeSalud = "Esta sano"; JugadorEnTurno.PrecisionBateo = 0.8; }
                if (p == 9) { JugadorEnTurno.EstadoDeSalud = "Esta resacado"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 10) { JugadorEnTurno.EstadoDeSalud = "Se contagio de COVID"; JugadorEnTurno.PrecisionBateo = 0.50; }
                if (p == 11) { JugadorEnTurno.EstadoDeSalud = "Esta resacado"; JugadorEnTurno.PrecisionBateo = 0.6; }
                if (p == 12) { JugadorEnTurno.EstadoDeSalud = "Se trasnocho"; JugadorEnTurno.PrecisionBateo = 0.5; }
                if (p == 13) { JugadorEnTurno.EstadoDeSalud = "Esta sano"; JugadorEnTurno.PrecisionBateo = 0.8; }
            }
            

            CondicionRTB.Text = JugadorEnTurno.EstadoDeSalud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PrimeraVez)
            {
                PrimeraVez = false;
                TotalLanzamientos++;
                TipoLanzamiento();
                ContadorLanzamientos++;
                Movimiento.Start();
            }
            Movimiento.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimiento.Stop();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            Iniciar();
            PrimeraVez = true;
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
            JugadorEnTurno = JugadorBLL.Buscar(1);
            JugadorLb.Text = JugadorEnTurno.Jugador;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f = new SeguimientoJugadores();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new SeguimientoJugadores();
            f.Show();
        }
    }
}
