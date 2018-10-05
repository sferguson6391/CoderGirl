using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            int rectangleLength = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            int rectangleWidth = int.Parse(Console.ReadLine());

            int CalculateArea = rectangleLength * rectangleWidth;
            Console.Write("The area of the rectangle is: " + CalculateArea);
            Console.ReadLine();
        }
    }
}
