using System;

namespace CG_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator myCalculator = new Calculator();

                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());
                Console.Write("Enter the operation you want to use: ");
                string operation = Console.ReadLine();

                if (operation == "addition" || operation == "+")
                {
                    myCalculator.AdditionMethod(number1, number2);
                    Console.Write($"The total is {myCalculator.Total}");
                }
                else if (operation == "subraction" || operation == "-")
                {
                    myCalculator.SubtractionMethod(number1, number2);
                    Console.Write($"The total is {myCalculator.Total}");
                }
                else if (operation == "multiplication" || operation == "*")
                {
                    myCalculator.MultiplicationMethod(number1, number2);
                    Console.Write($"The total is {myCalculator.Total}");
                }
                else if (operation == "division" || operation == "/")
                {
                    myCalculator.DivisionMethod(number1, number2);
                    Console.Write($"The total is {myCalculator.Total}");
                }
                else Console.WriteLine("Your input was not valid.");               

            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
