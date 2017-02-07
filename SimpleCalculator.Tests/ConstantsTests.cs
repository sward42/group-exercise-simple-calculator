using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void EnsureConstantsNotNull()
        {
            Constant constant = new Constant();
            Assert.IsNotNull(constant);
        }
        /*
        [TestMethod]
        public void EnsureVerifyConstantWorking()
        {
            Constant constant = new Constant();
            string expectedResult = "x=0";
            constant.verifyConstant();
            string actualResult = Console.ReadLine();
            Assert.AreEqual(expectedResult, actualResult);
        }*/
        /*
        [TestMethod]
        public void EnsureCanGetConstant()
        {
            Constant constant = new Constant();
            string expectedResult = "x=0";
            constant.getConstant(expectedResult);
            string actualResult = Console.ReadLine();
            Assert.AreEqual(expectedResult, actualResult);
        }*/
        /*
        [TestMethod]
        public void EnsureCanUpdateMathProblem()
        {
            Constant constant = new Constant();
            string expectedResult = "x";
            string actualResult = constant.updateMathProblemWithConstants("x");
            Assert.AreEqual(expectedResult, actualResult);
        }*/
    }
}
