using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_4_2.Test
{
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void EmptyListExceptionTest()
        {
            List list = new List();
            list.DeleteElement(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ExistenceException))]
        public void ExistenceExceptionTest()
        {
            List list = new List();
            list.AddElement(3);
            list.DeleteElement(5);
        }
    }
}
