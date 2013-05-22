using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _2_4_2.Test
{
    [TestClass]
    public class HashFunctionTest
    {
        [TestMethod]
        public void HashFunctionTest1()
        {
            IHashFunction hashfunction = new HashFunction1(5);
            Assert.AreEqual(hashfunction.GetIndex(53), 3);
        }

        [TestMethod]
        public void HashFunctionTest2()
        {
            int tmp = 53;
            IHashFunction hashfunction = new HashFunction2(5);
            Assert.AreEqual(hashfunction.GetIndex(tmp), tmp.GetHashCode() % 5);
        }
    }
}
