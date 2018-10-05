using System;

namespace CG_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather user text and assign to variable upperCase
            Console.Write("Enter your text: ");
            string upperCase = Console.ReadLine();

            //convert the text to upper case
            upperCase = upperCase.ToUpper();

            Console.Write(upperCase);
            Console.ReadLine();
        }
    }
}
