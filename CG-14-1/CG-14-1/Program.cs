using System;

namespace CG_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Enter your formula (i.e 10 + 4): ");
                    string input = Console.ReadLine();
                    Calculator myCalculator = new Calculator();
                    Console.WriteLine($"{input} = {myCalculator.CalculatorMethod(input)}");
                    Console.ReadLine();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
