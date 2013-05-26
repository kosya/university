using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_5_2.Test
{
    [TestClass]
    public class ExceptionsTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void EmptyListExceptionTest()
        {
            list.DeleteElement(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ExistenceException))]
        public void ExistenceExceptionTest()
        {
            list.AddElement(5);
            list.DeleteElement(3);
        }

        [TestMethod]
        [ExpectedException(typeof(RepeatedElementException))]
        public void RepeatedElementException()
        {
            list.AddElement(5);
            list.AddElement(5);
        }
    }
}
