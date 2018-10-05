using System;

namespace ReviewProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //area of a rectangle
            /*Console.Write("Enter the length: ");
            decimal rectangleLength = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            decimal rectangleWidth = decimal.Parse(Console.ReadLine());

            decimal rectangleArea = rectangleLength * rectangleWidth;
            Console.WriteLine($"The area is: {rectangleArea}");
            Console.ReadLine();*/


            //miles per gallon
            /*Console.Write("Enter the number of miles you have driven: ");
            decimal milesDriven = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the amount of gallons of gas you've used: ");
            decimal gasUsed = decimal.Parse(Console.ReadLine());

            decimal milesPerGallon = milesDriven / gasUsed;
            Console.WriteLine($"Your miles per gallon is: {milesPerGallon}");
            Console.ReadLine();*/


            //area of a circle
            /*double radiusCircle;
            do
            {
                Console.Write("Enter the radius of the circle: ");
                radiusCircle = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * radiusCircle * radiusCircle;

                if (radiusCircle > 0)
                {
                    Console.Write($"The area is: {areaCircle}");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("A negative number does not compute.");
                    Console.ReadLine();
                }

                Console.Clear();
            } while (radiusCircle <= 0);*/


            //tip calculator
            /*Console.Write("What is the subtotal of your meal: ");
            double subTotal = double.Parse(Console.ReadLine());

            Console.Write("What percentage would you like to tip: ");
            double tipWanted = double.Parse(Console.ReadLine());
            tipWanted = tipWanted * 0.01;

            double tipCalculator = subTotal * tipWanted;
            Console.WriteLine("The tip should be " + string.Format("{0:C}", tipCalculator));
            Console.ReadLine();*/


            //99 bottles loop
            /*for (int i = 99; i >= 1; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. " +
                    $"\nTake one down and pass it around, {i - 1} bottles of beer on the wall.");
            }
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer." +
                "\nGo to the store and buy some more, 99 bottles of beer on the wall.");
            Console.ReadLine();*/


            //even integer loop
            /*for (int i = 0; i < 51; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();*/


            //10 random numbers
            /*for (int i = 0; i < 10; i++)
            {
                Random ran = new Random();
                int randomNumber = ran.Next(0, int.MaxValue);
                Console.WriteLine(randomNumber);
            }
            Console.ReadLine();*/


            //gpa calculator
            /*string enterGrade;
            decimal userGrade = 0;
            decimal userCredits = 0;
            decimal userGPA = 0;
            decimal userTotalCredits = 0;
            decimal userTotal = 0;
            do
            {
                Console.Write("Enter your grade (0.0-4.0): ");
                userGrade = decimal.Parse(Console.ReadLine());
                Console.Write("Enter your number of credits: ");
                userCredits = decimal.Parse(Console.ReadLine());
                userTotalCredits += userCredits;
                userTotal += Convert.ToInt32(userGrade) * userCredits;

                Console.Write("Enter another grade? [y/n]: ");
                enterGrade = Console.ReadLine();



            } while (enterGrade == "y");

            userGPA += userTotal / userTotalCredits;
            Console.Write($"Your GPA is: {String.Format($"{userGPA:0.00}")}");
            Console.ReadLine();*/


            //array
            /*int[] numberArray = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach (int number in numberArray)
            {
                Console.Write(number);
            }
            Console.ReadLine();*/

            //exam score
            /*Console.Write("Enter the exam score [0-100]: ");
            int userScore = int.Parse(Console.ReadLine());
            Console.Write($"The letter grade is: {LetterGrade(userScore)}");
            Console.ReadLine();*/


            //is even
            /*Console.Write("Enter a whole number to see if it is even: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.Write(IsEven(userNumber));
            Console.ReadLine();*/


            //number of digits
            /*Console.Write("Enter a number to see how many digits there are in it: ");
            double userNumber = double.Parse(Console.ReadLine());
            Console.Write($"The number {userNumber} has {ReturnDigits(userNumber)} digits.");
            Console.ReadLine();*/


            //pick an activity
            Console.Write("Is it hot? yes or no: ");
            string userHot = Console.ReadLine();
            Console.Write("Is it wet? yes or no: ");
            string userWet = Console.ReadLine();

            Console.WriteLine(PickActivity(userHot, userWet));
            Console.ReadLine();
        }

        //exam score method
        /*public static string LetterGrade(int examScore)
        {
            if (examScore >= 90) return "A";
            else if (examScore >= 80) return "B";
            else if (examScore >= 70) return "C";
            else if (examScore >= 60) return "D";
            else return "F";
        }*/


        //IsEven method
        /*public static string IsEven(int userNumber)
        {
            if (userNumber % 2 == 0) return "True";
            else return "False";
        }*/


        //number of digits method
        /*public static double ReturnDigits(double n)
        {
            return Math.Floor(Math.Log10(n) + 1);
        }*/


        //PickActivity method
        public static string PickActivity(string hot, string wet)
        {
            if (hot == "yes" && wet == "yes")
                return "You should watch Netflix";
            else if (hot == "no" && wet == "no")
                return "You should go to a cafe and read";
            else if (hot == "yes" && wet == "no")
                return "You should go swimming";
            else if (hot == "no" && wet == "yes")
                return "You should paint";
            else return "Sorry, that input doesn't work";

        }

    }
}
