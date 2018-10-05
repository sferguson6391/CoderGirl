namespace CG_7_3
{
    public class Card
    {
        public string number { get; set; }
        public string suit { get; set; }

        public Card(string number, string suit)
        {
            this.number = number;
            this.suit = suit;
        }

        public string FullCardName()
        {
            return $"{number} of {suit}";
        }
    }
}
