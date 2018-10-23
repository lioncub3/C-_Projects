using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculater;

namespace CalculateTests
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        [DataRow(6, 2, 3)]
        [DataRow(-6, 2, -3)]
        [DataRow(-6, -2, 3)]
        [DataRow(0, 2, 0)]

        public void DivisionTestMethod1(int a, int b, double rez)
        {
            Calculate calculate = new Calculate();

            Assert.AreEqual<int>(Convert.ToInt32(rez), calculate.Division(a, b));
        }

        [TestMethod]
        public void DivisionByZeroTestMethod1()
        {
            Calculate calculate = new Calculate();

            Assert.ThrowsException<DivideByZeroException>(() =>
         {
             calculate.Division(5, 0);
         });
        }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(-6, 2, -4)]
        [DataRow(-6, -2, -8)]
        [DataRow(0, 2, 2)]
        public void SumTestMethod(int a, int b, int rez)
        {
            Calculate calculate = new Calculate();

            Assert.AreEqual<int>(rez, calculate.Sum(a, b));
        }

        [TestMethod]
        [DataRow(2, 2, 0)]
        [DataRow(10, 5, 5)]
        [DataRow(22, 2, 20)]
        [DataRow(6, 7, -1)]
        public void SubTestMethod(int a, int b, int rez)
        {
            Calculate calculate = new Calculate();

            Assert.AreEqual<int>(rez, calculate.Sub(a, b));
        }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(10, 5, 50)]
        [DataRow(22, 2, 44)]
        [DataRow(6, 7, 42)]
        public void DobTestMethod(int a, int b, int rez)
        {
            Calculate calculate = new Calculate();

            Assert.AreEqual<int>(rez, calculate.Dob(a, b));
        }
    }
}
