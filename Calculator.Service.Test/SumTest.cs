using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Service.Test
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var sum = new Sum();
            decimal result = sum.Calculate(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
