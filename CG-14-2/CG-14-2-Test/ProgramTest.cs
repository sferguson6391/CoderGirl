using System;
using Xunit;
using CG_14_2;

namespace CG_14_2_Test
{
    public class ProgramTest
    {

        [Fact]
        public void CalculatorMethod_addition()
        {
            var calculator = new Calculator();
            var result = calculator.CalculatorMethod("2 + 2");
            Assert.Equal(4, result);
        }

        [Fact]
        public void CalculatorMethod_subraction()
        {
            var calculator = new Calculator();
            var result = calculator.CalculatorMethod("4 - 2");
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculatorMethod_multiplication()
        {
            var calculator = new Calculator();
            var result = calculator.CalculatorMethod("2 * 2");
            Assert.Equal(4, result);
        }

        [Fact]
        public void CalculatorMethod_division()
        {
            var calculator = new Calculator();
            var result = calculator.CalculatorMethod("2 / 2");
            Assert.Equal(1, result);
        }

        [Fact]
        public void CalculatorMethod_blank()
        {
            var calculator = new Calculator();
            try { var result = calculator.CalculatorMethod(""); }
            catch (Exception)
            { Assert.True(true); }
        }

        [Fact]
        public void CalculatorMethod_nospaces()
        {
            var calculator = new Calculator();
            try { var result = calculator.CalculatorMethod("2+2"); }
            catch (Exception)
            { Assert.True(true); }
        }
    }
}
