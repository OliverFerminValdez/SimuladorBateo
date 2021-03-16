using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBateo.Entidades
{
    public class RendimientoDiario
    {
        public int Dia { get; set; }
        public int HITS { get; set; }
        public int HRS { get; set; }
        public int FoulsDia { get; set; }
        public int Turnos { get; set; }
        public int LanzamientosFallados { get; set; }
    }
}
