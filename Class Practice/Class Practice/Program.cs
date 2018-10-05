using System;

namespace Class_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Console.WriteLine(myDeck.DrawACard());
            Console.ReadLine();
        }
    }

    class Card
    {
        public string Number { get; set; }
        public string Suit { get; set; }

        public Card (string number, string suit)
        {
            Number = number;
            Suit = suit;
        }

        public string FullCardName()
        {
            string fullCardName = Number + " of " + Suit;
            return fullCardName;
        }
    }

    class Deck
    {
        Card[] fullDeck = new Card[52];

        public Deck()
        {
            string[] numberArray = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suitArray = new string[] { "Hearts", "Diamonds", "Spades", "Clubs" };

            int i = 0;

            foreach (string number in numberArray)
            {
                foreach (string suit in suitArray)
                {
                    this.fullDeck[i] = new Card(number, suit);
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
