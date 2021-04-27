using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string y = "й";
        string q = "а";
        [TestMethod]
        public void TestMethod1()
        {
            Class1 a = new Class1();
            bool b = a.num(y);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 a = new Class1();
            bool b = a.let(q);
            Assert.AreEqual(true, b);
        }
    }
}
