﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_5_2.Test
{
    [TestClass]
    public class UniqueListTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        public void TestAddElement()
        {
            Assert.IsTrue(list.IsEmpty());
            list.AddElement(1);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(RepeatedElementException))]
        public void TestAddExistedElement()
        {
            list.AddElement(2);
            list.AddElement(2);
        }

        [TestMethod]
        public void TestDeleteElement()
        {
            list.AddElement(1);
            Assert.AreEqual(1, list.DeleteElement(1));
            Assert.IsTrue(list.IsEmpty());

            list.AddElement(1);
            list.AddElement(2);
            Assert.AreEqual(1, list.DeleteElement(1));
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(2, list.DeleteElement(2));
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void TestSearchElement()
        {
            list.AddElement(1);
            list.AddElement(2);
            list.AddElement(5);

            Assert.IsTrue(list.SearchElement(5));
            Assert.IsTrue(list.SearchElement(1));
            Assert.IsFalse(list.SearchElement(500));
        }
    }
}
