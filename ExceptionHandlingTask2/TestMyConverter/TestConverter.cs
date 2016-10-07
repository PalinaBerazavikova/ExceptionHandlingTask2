using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionHandlingTask2;

namespace TestMyConverter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res;
            Assert.IsTrue(MyConverter.MyTryParse("35 3453", out res));
           
        }
    }
}
