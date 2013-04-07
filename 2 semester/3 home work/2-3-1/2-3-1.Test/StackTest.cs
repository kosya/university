using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_1.Test
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
        public void PushTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());

            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.IsTrue(!stack.IsEmpty());
            Assert.AreEqual(1, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}
