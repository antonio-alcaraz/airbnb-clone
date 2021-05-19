using System;
using App;

namespace Poker
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
