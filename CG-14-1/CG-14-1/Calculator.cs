using System;
using System.Collections.Generic;
using System.Text;

namespace CG_14_1
{
    class Calculator
    {
        public string Addition { get; set; }
        public string Subtraction { get; set; }
        public string Multiplication { get; set; }
        public string Division { get; set; }
        public decimal Total { get; set; }

        public decimal AdditionMethod(int number1, int number2)
        {
            return Total = number1 + number2;
        }

        public decimal SubtractionMethod(int number1, int number2)
        {
            return Total = number1 - number2;
        }

        public decimal MultiplicationMethod(int number1, int number2)
        {
            return Total = number1 * number2;
        }

        public decimal DivisionMethod(int number1, int number2)
        {
            return Total = number1 / number2;
        }
    }
}
