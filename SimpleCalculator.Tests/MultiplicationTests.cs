using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void EnsureMultNotNull()
        {
            Multiplication multiplication = new Multiplication();
            Assert.IsNotNull(multiplication);
        }

        [TestMethod]
        public void EnsureMultWorking()
        {
            Multiplication multiplication = new Multiplication();
            int expectedResult = 2*3;
            int actualResult = multiplication.Multiply(2 ,3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanPrintMult()
        {
            Multiplication multiplication = new Multiplication();
            int expectedResult = 6;
            int actualResult = multiplication.PrintNumber(6);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
