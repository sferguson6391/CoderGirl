using System;
using System.Collections.Generic;

namespace NumberUtility
{
    public static class NumberCruncher
    {
        public static void EvenNumbers(List<int> numberList)
        {
            foreach (int number in numberList)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
            }
        }
    }
}
