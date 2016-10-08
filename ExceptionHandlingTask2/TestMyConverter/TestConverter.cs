using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionHandlingTask2;

namespace TestMyConverter
{
    [TestClass]
    public class TestConverter
    {
        [TestMethod]
        public void TestParse1()
        {
            TestParse(353453, MyConverter.MyParse("353453"));
        }
        [TestMethod]
        public void TestParse2()
        {
            TestParse(353453, MyConverter.MyParse("+353453"));
        }
        [TestMethod]
        public void TestParse3()
        {
            TestParse(-353453, MyConverter.MyParse("-353453"));
        }
        public void TestParse(int exp, int act)
        {
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestBigValue1()
        {
            TestValue("356800000000");
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestBigValue2()
        {
            TestValue("-356800000000");
        }

        public void TestValue(string str)
        {
            MyConverter.MyParse(str);
        }

        [TestMethod]
        public void TestDoubleValue1()
        {
            TestParse(3568000, MyConverter.MyParse("3568000,00000"));
        }
        [TestMethod]
        public void TestDoubleValue2()
        {
            TestParse(3568000, MyConverter.MyParse("3568000.00000"));
        }
        [TestMethod]
        [ExpectedException(typeof(WrongFormatException))]
        public void TestWrongValue3()
        {
            TestWrongValue("asdf");
        }
        public void TestWrongValue(string str)
        {
            MyConverter.MyParse(str);
        }
    }
}
