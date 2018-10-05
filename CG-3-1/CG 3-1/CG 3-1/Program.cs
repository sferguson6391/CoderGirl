using System;

namespace CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for a number and assign that number for the variable userValue
            Console.Write("Enter a number to see the month: ");
            string userValue = Console.ReadLine();

            //the output message that will be assigned based on the userValue
            string message = " ";

            //if, else if to assign the message month name based on the userValue
            if (userValue == "1")
                message = "January";
            else if (userValue == "2")
                message = "February";
            else if (userValue == "3")
                message = "March";
            else if (userValue == "4")
                message = "April";
            else if (userValue == "5")
                message = "May";
            else if (userValue == "6")
                message = "June";
            else if (userValue == "7")
                message = "July";
            else if (userValue == "8")
                message = "August";
            else if (userValue == "9")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";
            //else to assign a message for all inputs other than 1-12
            else
                message = "Sorry, that isn't associated with a month.";

            //output that shows the user what month is associated with the number they typed
            Console.WriteLine("The month corresponding to {0} is: {1}", userValue , message);
            Console.ReadLine();
        }
    }
}
