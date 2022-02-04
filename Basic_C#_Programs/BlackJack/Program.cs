using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            BlackjackGame game = new BlackjackGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();

            Deck deck = new Deck();
            deck.Shuffle(5);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count());
            Console.ReadLine();
        }
    }
}
