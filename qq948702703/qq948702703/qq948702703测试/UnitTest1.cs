using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace qq948702703测试
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            jisuan a = new jisuan(1);
            int num1 = 7;
            int num2 = 8;
            int sum;
                        sum = num1 + num2;
            Assert.IsTrue(sum == 15); 
                }
    }
}
