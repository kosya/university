using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_4.Test
{
    [TestClass]
    public class StackTest
    {
        private Stack stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack();
        }

        [TestMethod]
        public void TestAmountOfElements()
        {
            Assert.IsTrue(stack.AmountOfElements() == 0);
            stack.Push(2);
            Assert.IsTrue(stack.AmountOfElements() == 1);
            stack.Push(2);
            Assert.IsTrue(stack.AmountOfElements() == 2);
        }

        [TestMethod]
        public void TestPush()
        {
            Assert.IsTrue(stack.AmountOfElements() == 0);
            stack.Push(1);
            Assert.IsTrue(stack.AmountOfElements() == 1);
        }

        [TestMethod]
        public void TestPop()
        {
            stack.Push(4);
            Assert.IsTrue(stack.AmountOfElements() == 1);
            Assert.AreEqual(stack.Pop(), 4);
            Assert.IsTrue(stack.AmountOfElements() == 0);

            stack.Push(1);
            stack.Push(2);
            Assert.IsTrue(stack.AmountOfElements() == 2);
            Assert.AreEqual(stack.Pop(), 2);
            Assert.IsTrue(stack.AmountOfElements() == 1);
            Assert.AreEqual(stack.Pop(), 1);
            Assert.IsTrue(stack.AmountOfElements() == 0);
        }
    }
}
