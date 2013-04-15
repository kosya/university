using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_4.Test
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator("2222+33*4-10+0-177");
        }

        [TestMethod]
        public void TestGetNumber()
        {
            Assert.AreEqual(calculator.GetNumber(-1), 2222);
            Assert.AreEqual(calculator.GetNumber(4), 33);
            Assert.AreEqual(calculator.GetNumber(7), 4);
            Assert.AreEqual(calculator.GetNumber(9), 10);
            Assert.AreEqual(calculator.GetNumber(12), 0);
            Assert.AreEqual(calculator.GetNumber(14), 177);
        }

        [TestMethod]
        public void TestCalculate()
        {
            Assert.AreEqual(calculator.Calculate(), 2167);
            calculator = new Calculator("0");
            Assert.AreEqual(calculator.Calculate(), 0);
        }
    }
}
