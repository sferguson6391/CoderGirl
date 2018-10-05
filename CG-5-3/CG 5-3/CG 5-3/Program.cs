using System;

namespace CG_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign variables that get the random value given from the methods
            int userTotal = RollDice();
            int computerTotal = RollDice();

            Console.WriteLine("Welcome to the Dice Game!");
            Console.WriteLine("The first one to 20 wins");
            Console.WriteLine("Press enter to begin the game");
            Console.ReadLine();
            //do while statement that will add the rolls together and see if the total is below or above 20 
            //and execute an action based on that
            do
            {
                    if (userTotal >= 20)
                    {
                        Console.WriteLine($"You are the winner with a total of {userTotal}!");
                        Console.ReadLine();
                        return;
                    }
                    else if (userTotal < 20)
                        Console.WriteLine($"Your total is: {userTotal}");

                    Console.WriteLine("Press enter for the computer to roll");
                    Console.ReadLine();


                //adds another random roll to the user total
                userTotal += RollDice();

                //do while statement that will see if the computer's roll is below or above 20 
                //and execute an action based on that

                    if (computerTotal >= 20)
                    {
                        Console.WriteLine($"The computer is the winner with a total of {computerTotal}!");
                        Console.ReadLine();
                        return;
                    }
                    else if (computerTotal < 20)
                        Console.WriteLine($"The computers total is: {computerTotal}");

                    Console.WriteLine("Press enter for your roll");
                    Console.ReadLine();

                //adds another random roll to the user total
                computerTotal += RollDice();

            } while (userTotal < 20 || computerTotal < 20);
        }

        /// <summary>
        /// chooses a random number between 2 and 12 to imitate a two dice roll by the user
        /// </summary>
        /// <returns>int</returns>
        public static int RollDice()
        {
                Random randomization = new Random();
                int rollDice = randomization.Next(2, 13);
                return rollDice;          
        }
    }
}
