using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter up to 30 names
            Console.WriteLine("Enter up to 30 names to add them to the raffle: ");  

            //define the array with 30 elements
            string[] nameArray = new string[30];
            int count = 0;
            //create a loop to collect the names
            for (int i = 0; i < nameArray.Length; i++)
            {
                string userNames = Console.ReadLine();
                //If the user hits enter without entering a name, assume they are done and stop asking them
                if (userNames == "") break;
                nameArray[i] = userNames;
                //count the number of elements the user inputs
                count++;
                //could use count = i because that is how many names the user has entered as well
            }

            //randomly choose a name from the array and write it to the console as the winner
            Random ran = new Random();
            string winner = nameArray[ran.Next(0, count)];
            //int winner = ran.Next(0,count);
            //Console.WriteLine($"The winner is {names[winner]";
            Console.WriteLine($"The winner of the raffle is: {winner}");

            //write the list of other names that did not win
            Console.WriteLine("The losers are: ");
            foreach (var name in nameArray)
            {
                //exclude the name of the winner and any of the 30 elements that the user did not give a name to
                if (name == winner || name == null) continue;
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
