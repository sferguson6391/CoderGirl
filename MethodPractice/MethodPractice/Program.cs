using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            Console.Write("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();

        }

        private static void ReverseString(string message)
        {
            char[] messagearray = message.tochararray();
            array.reverse(messagearray);
            foreach (char item in messagearray)
            {
                console.write(item);
            }
            console.write(" ");
        }

    }
}
