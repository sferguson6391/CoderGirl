using System;

namespace CG_14_2
{
    public class Program
    {
        static void Main(string[] args)
        {
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
