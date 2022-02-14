using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BlackJack
{
    class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = Deck.Cards.First().ToString();
            Console.WriteLine(card);
            using(StreamWriter file = new StreamWriter(@"C:\Users\mproo\Documents\GitHub\TechAcademy_C-Sharp_Unity\Basic_C#_Programs\BlackJack\Log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);

            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
