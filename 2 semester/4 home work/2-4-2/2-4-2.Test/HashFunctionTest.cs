using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_4_2.Test
{
    [TestClass]
    public class HashFunctionTest
    {
        private HashFunction hashfunction;

        [TestInitialize]
        public void Initialize()
        {
            hashfunction = new HashFunction(5);
        }

        [TestMethod]
        public void TestGetIndex()
        {
            Assert.AreEqual(hashfunction.GetIndex(5), 0);
            Assert.AreEqual(hashfunction.GetIndex(4), 4);
        }
    }
}
