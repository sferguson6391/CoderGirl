using System;

namespace CG_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop to keep calculator running
            while (Calculator());
        }
        
        private static bool Calculator()
        {
            //gather user input and assign to variable numberOne, numberTwo, and operation
            Console.Clear();
            Console.Write("Enter the first number: ");
            decimal numberOne = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal numberTwo = decimal.Parse(Console.ReadLine());
            Console.Write("Enter addition, subraction, division, or multiplication: ");
            string operation = Console.ReadLine();

            //assign variable
            decimal solution = 0;

            //use user input to determine operation for solution

            if (numberTwo == 0 && (operation == "division" || operation == "/"))
                Console.Write("Error");
            else if (operation == "addition" || operation == "+")
                solution = Addition(numberOne, numberTwo);
            else if (operation == "subraction" || operation == "-")
                solution = Subraction(numberOne, numberTwo);
            else if (operation == "division" || operation == "/")
                solution = Division(numberOne, numberTwo);
            else if (operation == "multiplication" || operation == "*")
                solution = Multiplication(numberOne, numberTwo);
            //to write output for anything else that won't calculate
            else
            {
                Console.Write("Sorry, that does not calculate");
                Console.ReadLine();
                return false;
            }

            //to write output for the if and else if statements
            Console.Write(solution);
            Console.ReadLine();
            return true;
        }

        

        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="numberOne">a number</param>
        /// <param name="numberTwo">a number</param>
        /// <returns>decimal</returns>
        public static decimal Addition(decimal numberOne, decimal numberTwo)
        {
            return numberOne + numberTwo;
        }

        /// <summary>
        /// subtracts two numbers
        /// </summary>
        /// <param name="numberOne">a number</param>
        /// <param name="numberTwo">a number</param>
        /// <returns>decimal</returns>
        public static decimal Subraction(decimal numberOne, decimal numberTwo)
        {
            return numberOne - numberTwo;
        }

        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <param name="numberOne">a number</param>
        /// <param name="numberTwo">a number</param>
        /// <returns>decimal</returns>
        public static decimal Division(decimal numberOne, decimal numberTwo)
        {
            return (numberOne) / numberTwo;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <param name="numberOne">a number</param>
        /// <param name="numberTwo">a number</param>
        /// <returns>decimal</returns>
        public static decimal Multiplication(decimal numberOne, decimal numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}
