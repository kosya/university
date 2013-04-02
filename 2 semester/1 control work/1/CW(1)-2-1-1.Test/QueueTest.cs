using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CW_1__2_1_1.Test
{
    [TestClass]
    public class QueueTest
    {
        private Queue queue; 

        [TestInitialize]
        public void Initialize()
        {
            queue = new Queue();
        }

        [TestMethod]
        public void EnqueueTest()
        {
            Assert.IsTrue(queue.IsEmpty());
            queue.Enqueue(1, 1);
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void DequeueTest()
        {
            queue.Enqueue(1, 1);
            Assert.AreEqual(1, queue.Dequeue());
            Assert.IsTrue(queue.IsEmpty());

            queue.Enqueue(1, 1);;
            queue.Enqueue(2, 2);;
            Assert.AreEqual(1, queue.Dequeue());
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.IsTrue(queue.IsEmpty());
        }
    }
}
