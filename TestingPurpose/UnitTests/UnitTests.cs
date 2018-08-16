using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingPurpose;

namespace UnitTests
{
    [TestClass]
    public class TestingPurposeTests
    {
        [TestMethod]
        public void Sum_NegativeNumbers_CorrectCalculations()
        {
            //Arrange
            var toBeTested = new ToBeTestet();
            var a = -10;
            var b = -10;

            //Act
            var result = toBeTested.Sum(a, b);

            //Assert
            Assert.AreEqual(result, -20);
        }
        [TestMethod]
        public void Sum_LargeNumbers_success()
        {
            //Arrange
            var toBeTested = new ToBeTestet();
            var a = 32000;
            var b = 32000;

            //Act
            var result = toBeTested.Sum(a, b);

            //Assert
            Assert.AreEqual(result, 64000);
        }
    }
}
