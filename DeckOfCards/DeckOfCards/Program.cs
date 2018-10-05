using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(52);

            int counter = 0;

            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string faceValue;
                    if (i < 11) faceValue = i.ToString();
                    else if (i == 11) faceValue = "Jack";
                    else if (i == 12) faceValue = "Queen";
                    else if (i == 13) faceValue = "King";
                    else faceValue = "Ace";

                    string suit;
                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "Clubs";
                    else suit = "Spades";

                    deck.Cards[counter] = new Card
                    {
                        FaceValue = faceValue,
                        Suit = suit
                    };

                    counter++;
                }
            }

            Console.WriteLine(deck.Draw().FullCardName());
            Console.ReadLine();
        }
    }
}
