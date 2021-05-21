using System;
using System.Collections.Generic;

namespace Poker
{
    public class Jugada
    {
        public Ganador Comparar(List<string> jugadorUno, List<string> jugadorDos, List<string> mesa)
        {
            return Ganador.Empate;
            return Ganador.Primero;
            return Ganador.Segundo;
        }
    }

    public enum Ganador
    {
        Empate,
        Primero,
        Segundo
    }
}
