using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            PokerGame poker = new PokerGame();
            poker.Init();
            poker.Finish();
        }
    }
}