using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array with the following values: 1, 1, 2, 3, 5, 8
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            //loop through the array and print out each value
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
