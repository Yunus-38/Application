using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            int result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            int result = _calculator.Subtract(10, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            int result = _calculator.Multiply(4, 3);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_ByNonZeroNumber_ReturnsCorrectQuotient()
        {
            int result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
