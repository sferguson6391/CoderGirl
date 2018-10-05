using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather user input and assign to variable numberOne
            Console.Write("Enter the first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            //gather user input and assign to variable numberTwo
            Console.Write("Enter the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            //gather user input and assign to variable operation
            Console.Write("Enter addition, subraction, division, or multiplication: ");
            string operation = Console.ReadLine();

            //assign variable
            int solution;

            //use user input to determine operation for solution
            if (operation == "addition" || operation == "+")
                solution = numberOne + numberTwo;
            else if (operation == "subraction" || operation == "-")
                solution = numberOne - numberTwo;
            else if (operation == "division" || operation == "/")
                solution = numberOne / numberTwo;
            else if (operation == "multiplication" || operation == "*")
                solution = numberOne * numberTwo;
            //to write output for anything else that won't calculate
            else
            {
                Console.Write("Sorry, that does not calculate");
                Console.ReadLine();
                return;
            }

            //to write output for the if and else if statements
            Console.Write(solution);
            Console.ReadLine();
        }
    }
}
