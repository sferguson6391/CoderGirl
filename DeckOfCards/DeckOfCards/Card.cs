using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public string FaceValue { get; set; }
        public string Suit { get; set; }

        public string FullCardName()
        {
            return $"{FaceValue} of {Suit}";
        }
    }
}
