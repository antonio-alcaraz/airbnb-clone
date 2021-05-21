using System;
using Poker;
using Xunit;
using System.Collections.Generic;

namespace PokerTests
{
    public class JugadaTests
    {
        [Fact]
        public void SiElJugadorUnoTieneLaCartaMasAltaGana()
        {
            Jugada jugada = new Jugada();

            var ganador = jugada.Comparar(
                new List<string> { "AC", "1C" },
                new List<string> { "KC", "QC" },
                new List<string> { "KS", "QS", "JS", "10S", "9S", "8S" }
            );

            Assert.Equal(Ganador.Primero, ganador);
        }

        [Fact]
        public void SiEljugadorDosTieneLaCartaMasAltaGana()
        {
            Jugada jugada = new Jugada();

            var ganador = jugada.Comparar(
                new List<string> { "KC", "QC" },
                new List<string> { "AC", "1C" },
                new List<string> { "KS", "QS", "JS", "10S", "9S", "8S" }
            );

            Assert.Equal(Ganador.Segundo, ganador);
        }

        [Fact]
        public void SiLosDosTienenLaMismaCartaMasAltaEmpate()
        {
            Jugada jugada = new Jugada();

            var ganador = jugada.Comparar(
                new List<string> { "KS", "QC" },
                new List<string> { "KC", "1C" },
                new List<string> { "AS", "QS", "JS", "10S", "9S", "8S" }
            );

            Assert.Equal(Ganador.Empate, ganador);
        }

        [Fact]
        public void LaSegundaCartaMasAltaInfluyeEnElResultadoDeEmpate()
        {
            Jugada jugada = new Jugada();

            var ganador = jugada.Comparar(
                new List<string> { "AC", "KS" },
                new List<string> { "AS", "10K" },
                new List<string> { "10D", "9D", "8D", "7D", "6D", "5D" }
            );

            Assert.Equal(Ganador.Primero, ganador);
        }
    }
}
