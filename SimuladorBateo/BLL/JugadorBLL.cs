using SimuladorBateo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBateo.BLL
{
    public class JugadorBLL
    {
        public static Jugadores Buscar(int id)
        {
            Jugadores a = new Jugadores();
            try
            {
                foreach (var item in Simulador.ListaJugadores)
                {
                    if (item.JugadorId == id)
                    {
                        a = item;
                    }
                }
                return a;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Jugadores> GetJugadores()
        {
            List<Jugadores> l = new List<Jugadores>();

            l = Simulador.ListaJugadores;

            return l;
        }
    }
}
