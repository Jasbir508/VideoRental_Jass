using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental_Jass;

namespace UnitTestProject_Jass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestCls ownCode = new UnitTestCls();
            var result = ownCode.AdditionOfNumbers(10, 20);
            Assert.IsTrue(result == 30);
        }
    }
}
