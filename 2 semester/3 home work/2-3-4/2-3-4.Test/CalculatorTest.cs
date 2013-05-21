using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_4.Test
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;

        [TestMethod]
        public void TestCalculate()
        {
            calculator = new Calculator("22 13 +");
            Assert.AreEqual(calculator.Calculate(), 35);

            calculator = new Calculator("-22 13 -");
            Assert.AreEqual(calculator.Calculate(), -35);

            calculator = new Calculator("-21,3 10 *");
            Assert.AreEqual(calculator.Calculate(), -213);

            calculator = new Calculator("22 2 /");
            Assert.AreEqual(calculator.Calculate(), 11);

            calculator = new Calculator("22 2 / 3 + -7 - 6 *");
            Assert.AreEqual(calculator.Calculate(), 126);

            calculator = new Calculator("0");
            Assert.AreEqual(calculator.Calculate(), 0);
        }
    }
}
