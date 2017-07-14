using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Service.Test
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class MultiplyTest
    {
        public MultiplyTest()
        {
            //
            // TODO: Add constructor logic here
            //

            multiplier = new Multiply();
        }

        private Calculator.Service.Multiply multiplier;

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void MultiplyTwoNumber()
        {
            //Arrange
            var number1 = 5;
            var number2 = 6;

            //Act
            var result = multiplier.Calculate(number1, number2);

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void ReturnZeroForLargeNamber()
        {
            //arrange
            var number1 = 1000000000000;
            var number2 = 200000000000;

            //act
            var result = multiplier.Calculate(number1,number2);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void returnexceptionforzero()
        {
            //arrange 
            var number1 = 0;
            var number2 = 589;

            //act
            var result = multiplier.Calculate(number1, number2);

        }
            //a
    }
}

