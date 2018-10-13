using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CG_14_2
{
    public class Calculator
    {
        public decimal CalculatorMethod(string input)
        {
            decimal sum = 0;
            string[] inputArray = input.Split(" ");
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Input is required.");
            if (inputArray.Contains("+"))
            {
                return sum = decimal.Parse(inputArray[0]) + decimal.Parse(inputArray[2]);
            }
            else if (inputArray.Contains("-"))
            {
                return sum = decimal.Parse(inputArray[0]) - decimal.Parse(inputArray[2]);

            }
            else if (inputArray.Contains("/"))
            {
                return sum = decimal.Parse(inputArray[0]) / decimal.Parse(inputArray[2]);
            }
            else if (inputArray.Contains("*"))
            {
                return sum = decimal.Parse(inputArray[0]) * decimal.Parse(inputArray[2]);
            }
            else if (!(inputArray.Contains("+") || inputArray.Contains("-") ||
                inputArray.Contains("/") || inputArray.Contains("*")))
                throw new Exception("Sorry, your input was not in the correct format.");
            return 0;
        }
    }
}
