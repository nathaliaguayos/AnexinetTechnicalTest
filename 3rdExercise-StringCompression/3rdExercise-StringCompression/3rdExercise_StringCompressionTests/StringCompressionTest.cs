using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3rdExercise_StringCompression;

namespace _3rdExercise_StringCompressionTests
{
    [TestClass]
    public class StringCompressionTest
    {
        [TestMethod]
        public void TestingStringBasicCompression()
        {
            //Arrange
            string originalString = "aabcccccaaa"; // aabcccccaaadfrgt

            //Act
            StringCompression stringCompression = new StringCompression();
            string result = stringCompression.StringCompressionProcess(originalString);
            //Assert
            Assert.IsTrue(result.Length < originalString.Length);
        }
        [TestMethod]
        public void TestingStringResultantIsGreaterThanOriginal()
        {
            //Arrange
            string originalString = "aabcccccaaadfrgt";

            //Act
            StringCompression stringCompression = new StringCompression();
            string result = stringCompression.StringCompressionProcess(originalString);
            //Assert
            Assert.IsFalse(result.Length < originalString.Length);
        }
    }
}
