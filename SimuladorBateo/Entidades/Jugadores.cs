using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBateo.Entidades
{
    public class Jugadores
    {
        public int JugadorId { get; set; }
        public string Jugador { get; set; }
        public double PrecisionBateo { get; set; } = 0.5;
        public int Hits { get; set; }
        public int Fouls { get; set; }
        public int HR { get; set; }
        public int Turnos { get; set; }
        public string EstadoDeSalud { get; set; }
        public List<RendimientoDiario> RDiario { get; set; } = new List<RendimientoDiario>();
    }
}
