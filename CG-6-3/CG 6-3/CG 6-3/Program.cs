using System;

namespace CG_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //first sentence in Alice in Wonderland using \n to break up lines
            string quote = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
            "\nand of having nothing to do: once or twice she had peeped into the book " +
            "\nher sister was reading, but it had no pictures or conversations in it, " +
            "\n‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";

            //gather the user input and assign it to a variable called userInput
            Console.Write("Write a statment to see if it is in the first sentence of Alice in Wonderland:");
            string userInput = Console.ReadLine();

            //return true if user has input part of the quote
            if (quote.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                Console.Write($"True, \"{userInput}\" is in the first sentence of Alice in Wonderland.");
            //return false if user has not input part of the quote
            else
                Console.Write($"False, {userInput} is not in the first sentence of Alice in Wonderland.");

            Console.ReadLine();
        }
    }
}
