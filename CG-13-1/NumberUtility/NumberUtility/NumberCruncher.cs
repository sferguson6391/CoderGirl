using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberUtility
{
        public static class NumberCruncher
        {
            public static int EvenNumbers(List<int> numberList)
            {
            int sum = (numberList.Where(n => n % 2 == 0)).Sum();
            /*foreach (int number in numberList)
            {
                if (number % 2 == 0)
                    sum += number;
            }*/
            return sum;
            }
        }
}
