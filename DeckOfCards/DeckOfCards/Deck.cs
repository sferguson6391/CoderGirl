using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        public Card[] Cards { get; set; }

        public Deck(int numberOfCards)
        {
            Cards = new Card[numberOfCards];
        }

        public Card Draw()
        {
            Random random = new Random();
            var number = random.Next(Cards.Length);
            return Cards[number];



            /*Card[] deck = new Card[52];
            int i = 0;
            foreach (var card in deck)
            {
                deck[i] = new Card();
                i++;
            }

            Random ran = new Random();
            return card[ran.Next(Cards[].Length)].FullCardName();*/
        }
    }
}
