using System;

namespace CG_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather a number from the user and assign to the variable userNumber
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            //define the variables for the multiplication total and the sum, loop from 2 to 20 with an increase by 1
            int total;
            int sum = 0;
            for (int number = 2; number < 21; number++)
            {
                //multiply the loop value by the number the user entered and write the output
                total = userNumber * number;
                Console.WriteLine(total);
                //sum needs to be in here becuase of the local variable "total"?
                sum += total;
            }

            //output the sum of all the previous values
            Console.WriteLine($"The sum of the intergers is {sum}");
            Console.ReadLine();
        }
    }
}
