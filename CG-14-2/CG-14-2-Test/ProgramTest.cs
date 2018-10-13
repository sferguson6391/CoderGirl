using System;
using Xunit;
using CG_14_2;

namespace CG_14_2_Test
{
    public class ProgramTest
    {
        //addition
        //subtraction
        //multiplication
        //division
        //blank space
        //no spaces

        [Fact]
        public void CalculatorMethod_addition()
        {
            var result = ProgramTest.CalculatorMethod("2 + 2");
            Assert.Equal("4", result);
        }
    }
}
