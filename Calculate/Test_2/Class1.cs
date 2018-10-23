using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculater;
using Xunit;

namespace Test_2
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(10, 0)]
        [InlineData(6, 0)]
        public void DivisionByZeroMethodTest(int a, int b)
        {
            Calculate calculator = new Calculate();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(a, b));
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(8, 2, 4)]
        [InlineData(2, 2, 1)]

        public void DivisionTestMethod1(int a, int b, double rez)
        {
            Calculate calculate = new Calculate();

            Assert.Equal<int>(Convert.ToInt32(rez), calculate.Division(a, b));
        }
    }
}
