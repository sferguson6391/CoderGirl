using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Chose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
                message = "Sorry we didn't understand that.";

            Console.WriteLine(message);
            Console.ReadLine();
            */

            /*Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Chose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            */

            /* Console.Write("You won a ");
             Console.Write(message);
             Console.Write("!");
             Console.ReadLine();
             */

            /*
            Console.WriteLine("You entered {0}, therefore you won a {1}!", userValue, message);
            Console.ReadLine();
            */

            int userValue = 2;
            string message = (userValue == 1) ? "boat" : "car";
            Console.WriteLine("{1} - {0}", userValue, message);
            Console.ReadLine();
        }
    }
}
