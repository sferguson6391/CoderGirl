using System;

namespace CG_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather two dates from the user and assign them to the variables firstDate and secondDate
            //and convert the strings to datetime
            Console.Write("Enter a first date: ");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter a second date: ");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            //find the difference between the two dates
            TimeSpan dateDifference = firstDate.Subtract(secondDate);
            //write the difference in days
            Console.Write($"The difference between those dates is {dateDifference.TotalDays} days");
            Console.ReadLine();
        }
    }
}
