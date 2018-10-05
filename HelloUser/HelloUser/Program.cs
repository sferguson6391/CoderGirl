using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + "!");
            Console.ReadLine();
        }
    }
}
