using System;

namespace PracticeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int greatestNumber = 0;
            if (number1 > number2 && number1 > number3)
                greatestNumber = number1;
            else if (number2 > number1 && number2 > number3)
                greatestNumber = number2;
            else if (number3 > number1 && number3 > number2)
                greatestNumber = number3;
            else Console.WriteLine("Sorry, there is not a greatest number.");

            Console.WriteLine($"{greatestNumber} is the greatest among the three.");
            Console.ReadLine();
        }
    }
}
