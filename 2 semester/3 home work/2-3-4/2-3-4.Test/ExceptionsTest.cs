using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_4.Test
{
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(DivideZeroException))]
        public void DivideZeroExceptionTest()
        {
            Calculator calculator = new Calculator("5 0 /");
            calculator.Calculate();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void EmptyStackExceptionTest()
        {
            IStack stack = new Stack();
            stack.Pop();

            stack = new StackArray();
            stack.Pop();
        }
    }
}
