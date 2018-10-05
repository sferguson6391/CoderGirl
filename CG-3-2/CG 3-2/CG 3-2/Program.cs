using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather users number guess and assign to the variable userGuess
            Console.WriteLine("Welcome to our contest!");
            Console.Write("Guess a number between 1 and 10: ");
            string userGuess = Console.ReadLine();
            
            //if user enters 8 they win, all else will lose
            string message = (userGuess == "8") ? "Congratulations, you won!" : "Sorry, you lose.";

            //write output based on user's input
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
