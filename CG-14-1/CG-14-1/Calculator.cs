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

        public void AdditionMethod(string addition, int number1, int number2, int total)
        {
            Addition = addition;
            total = number1 + number2;
        }

        public void SubtractionMethod(string subtraction, int number1, int number2, int total)
        {
            Subtraction = subtraction;
            total = number1 - number2;
        }

        public void MultiplicationMethod(string multiplication, int number1, int number2, int total)
        {
            Multiplication = multiplication;
            total = number1 * number2;
        }

        public void DivisionMethod(string division, int number1, int number2, int total)
        {
            Division = division;
            total = number1 / number2;
        }
    }
}
