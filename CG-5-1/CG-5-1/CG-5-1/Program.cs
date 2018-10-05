using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user to enter their first name, then have it enter their last name
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            //assign a new variable for the combined names and print the new value
            string fullName = CombineNames(firstName, lastName);
            Console.WriteLine($"Full name: {fullName}");

            Console.ReadLine();
        }

        //Create a method that combines the first and last name and returns it as a new value called CombineNames
        private static string CombineNames(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
