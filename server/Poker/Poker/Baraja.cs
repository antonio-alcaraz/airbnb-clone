using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class Baraja
    {
        private List<string> _list;
        private Random _superRandom = new Random(525);
        public Baraja(int contador=69)
        {
            _list = GetAllCards();
        }
        public string PickCard()
        {
            int next = _superRandom.Next(_list.Count-1);
            string nextCard = _list[next];
            _list.Remove(nextCard);
            return nextCard;
        }

        public void Reset()
        {
            _list = GetAllCards();
        }
        private List<string> GetAllCards() {
            return new List<string> {
                "AH",
                "KH",
                "QH",
                "JH",
                "10H",
                "9H",
                "8H",
                "7H",
                "6H",
                "5H",
                "4H",
                "3H",
                "2H",
                "AC",
                "KC",
                "QC",
                "JC",
                "10C",
                "9C",
                "8C",
                "7C",
                "6C",
                "5C",
                "4C",
                "3C",
                "2C",
                "AD",
                "KD",
                "QD",
                "JD",
                "10D",
                "9D",
                "8D",
                "7D",
                "6D",
                "5D",
                "4D",
                "3D",
                "2D",
                "AS",
                "KS",
                "QS",
                "JS",
                "10S",
                "9S",
                "8S",
                "7S",
                "6S",
                "5S",
                "4S",
                "3S",
                "2S",

            };
        }

        public override string ToString()
        {
            return $"{nameof(_list)}: {string.Join(" ",_list)}";
        }
    }
}
