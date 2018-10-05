using System;
using System.Text;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather user's first name and assign to userFirstName variable
            Console.Write("Enter your first name: ");
            string userFirstName = Console.ReadLine();

            //gather user's last name and assign to userLastName variable
            Console.Write("Enter your last name: ");
            string userLastName = Console.ReadLine();
           
            //call FullName method and input user input
            Console.Write(FullName(userFirstName, userLastName));
            Console.ReadLine();
        }

        /// <summary>
        /// combines first and last name into full name
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <returns>StringBuilder</returns>
        public static StringBuilder FullName(string firstName, string lastName)
        {
            return new StringBuilder($"Your full name: {firstName} {lastName}");
        }
    }
}
