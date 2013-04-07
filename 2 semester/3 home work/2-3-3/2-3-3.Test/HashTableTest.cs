using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_3_3.Test
{
    [TestClass]
    public class HashTableTest
    {
        private HashTable hashtable;
        private int tableSize = 6;

        [TestInitialize]
        public void Initialize()
        {
            hashtable = new HashTable(tableSize);
        }

        [TestMethod]
        public void TestHash()
        {
            Assert.AreEqual(hashtable.Hash(7), 1);
            Assert.AreEqual(hashtable.Hash(4), 4);
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(hashtable.IsEmpty());
            hashtable.AddElement(6);
            Assert.IsFalse(hashtable.IsEmpty());
        }

        [TestMethod]
        public void TestAddElement()
        {
            Assert.IsTrue(hashtable.IsEmpty());
            hashtable.AddElement(5);
            Assert.IsFalse(hashtable.IsEmpty());
        }

        [TestMethod]
        public void TestDeleteElement()
        {
            hashtable.AddElement(5);
            hashtable.DeleteElement(5);
            Assert.IsTrue(hashtable.IsEmpty());

            hashtable.AddElement(1);
            hashtable.AddElement(2);
            hashtable.DeleteElement(1);
            Assert.IsFalse(hashtable.IsEmpty());
            hashtable.DeleteElement(2);
            Assert.IsTrue(hashtable.IsEmpty());
        }

        [TestMethod]
        public void TestSearch()
        {
            Assert.IsFalse(hashtable.Search(5));

            hashtable.AddElement(2);
            hashtable.AddElement(3);

            Assert.IsTrue(hashtable.Search(2));
            Assert.IsFalse(hashtable.Search(17));
            Assert.IsTrue(hashtable.Search(3));
        }
    }
}
