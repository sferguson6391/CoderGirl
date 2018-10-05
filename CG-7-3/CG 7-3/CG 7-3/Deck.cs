using System;

namespace CG_7_3
{
    public class Deck
    {
        Card[] fullDeck = new Card[52];

        public Deck()
        {
            string[] numberArray = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                                    "Jack", "Queen", "King" };
            string[] suitArray = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };


            int i = 0;
            foreach (string number in numberArray)
            {
                foreach (string suit in suitArray)
                {
                    fullDeck[i] = new Card(number, suit);
                    i++;
                }
            }
        }

        public string DrawACard()
        {
            Random ran = new Random();
            return fullDeck[ran.Next(fullDeck.Length)].FullCardName();
        }
    }
}
