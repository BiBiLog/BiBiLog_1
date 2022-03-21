using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Controls;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_1()
        {
            int a = 3;
            int b = 5;
            int c = 6;
            int rez = 90;

            Page p = new Page();
            int actual = p.TestMethod1_1(a, b, c);
            Assert.AreEqual(rez, actual);
        }
    }
}
