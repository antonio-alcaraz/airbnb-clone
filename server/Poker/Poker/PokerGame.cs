using System;

namespace App
{
    public class PokerGame
    {
        public void Init()
        {
            int contador = 0;
            Baraja inglesa = new Baraja();
            string carta1 = inglesa.PickCard();
            Console.WriteLine(carta1);
            string carta2 = inglesa.PickCard();
            Console.WriteLine(carta2);
            string carta3 = inglesa.PickCard();
            Console.WriteLine(carta3);
            contador++;
            Baraja inglesa2 = new Baraja(contador);
            Console.WriteLine(inglesa.ToString());
        }

        public void Finish()
        {
            Console.WriteLine("Partida terminada");
        }
    }
}
