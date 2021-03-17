using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBateo.Entidades
{
    public class Seguimiento
    {
        public int JugadorId { get; set; }
        public string Jugador { get; set; }
        public int HITS { get; set; }
        public int HR { get; set; }
        public int Fouls { get; set; }
        public int Turnos { get; set; }
        public double AVG { get; set; }
        public string Problema { get; set; }
    }
}
