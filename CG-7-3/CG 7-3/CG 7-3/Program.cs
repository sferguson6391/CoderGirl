using System;

namespace CG_7_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Console.WriteLine(myDeck.DrawACard());
            Console.ReadLine();
        }
    }
}
