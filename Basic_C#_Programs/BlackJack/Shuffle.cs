using System;
using System.Collections.Generic;


namespace BlackJack
{
    class Shuffle
    {
        public static Deck ShuffleDeck(Deck deck, int times = 1)
        {
            for(int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            }
            return deck;
        }
    }
}
