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

        [TestMethod]
        public void TestAddEmptyString()
        {
            var sum = new Sum();
            int result = sum.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddOneParameter()
        {
            var sum = new Sum();
            int result = sum.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestAdd2Parameters()
        {
            var sum = new Sum();
            int result = sum.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestAddUnknownParameters()
        {
            var sum = new Sum();
            
            int result = sum.Add("1,2,3,4,5,6,7");
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void TestAddNewLineSeparator()
        {
            var sum = new Sum();

            int result = sum.Add("1,2,3\n4,5\n6,7");
            Assert.AreEqual(28, result);
        }


        [TestMethod]
        public void TestAddSpecifySeprator()
        {
            var sum = new Sum();

            int result = sum.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }




    }
}
