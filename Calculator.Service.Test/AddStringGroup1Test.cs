using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Service.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AddStringGroup1Test
    {
        public AddStringGroup1Test()
        {
            stringAdder = new AddStringGroup1();
        }

        private Calculator.Service.AddStringGroup1 stringAdder;


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
        public void AddTwoNumber()
        {
            //arrange
            var text = "1,2";

            //act
            var result = stringAdder.Add(text);

            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void retrnzeroifempty()
        {
            //arrange
            var text = "";

            //act

            var result = stringAdder.Add(text);

            //assert

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnSelfIfOneNumber()
        {
            //arrange
            var text = "1";

            //act
            var result = stringAdder.Add(text);

            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowExceptionIfMoreThanTwoInput()
        {
            //arange
            var text = "1,2,3";

            //act

            var result = stringAdder.Add(text);
        }

        [TestMethod]
        public void AddUnknownCountNumbers()
        {
            //arrange
            var numbers = new System.Collections.Generic.List<decimal>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            //act
            var result = stringAdder.AddNumbers(numbers);

            //assert
            Assert.AreEqual(6, result);
        }
          
    }
}
