using System;
using System.Data;

namespace CG_14_1_
{
    static public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your formula: ");
                var formula = Console.ReadLine();

                DataTable dt = new DataTable();
                var answer = (int)dt.Compute(formula, "");
                Console.WriteLine($"{formula} = {answer}");
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
