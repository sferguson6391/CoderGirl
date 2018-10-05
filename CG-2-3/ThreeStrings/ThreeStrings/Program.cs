using System;

namespace ThreeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word number one: ");
            string WordOne = Console.ReadLine();

            Console.Write("Enter word number two: ");
            string WordTwo = Console.ReadLine();

            Console.Write("Enter word number three: ");
            string WordThree = Console.ReadLine();

            Console.WriteLine(WordOne + " " + WordTwo + " " + WordThree);
            Console.ReadLine();
        }
    }
}
