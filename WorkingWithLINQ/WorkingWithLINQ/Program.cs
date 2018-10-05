using System;

namespace WorkingWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines you want: ");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i <= lines; i++)
            {
                for (int k = 0; k < (lines - i); k++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < (i - 1); m++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
