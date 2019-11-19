using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1stExercise_LeapYear;

namespace _1stExercise_LeapYearTests
{
    [TestClass]
    public class FindingALeapYearTest
    {
        [TestMethod]
        public void TestNonYearString()
        {
            //Arrange
            FindingALeapYear findingALeapYear = new FindingALeapYear();
            Exception exception = null;

            //Act
            try
            {
                bool isALeapYear = findingALeapYear.IsLeapYear("");
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            //Assert
            Assert.IsNotNull(exception);
        }


        [TestMethod]
        public void TestYear2001()
        {
            //Arrange
            FindingALeapYear findingALeapYear = new FindingALeapYear();


            //Act
            var result = findingALeapYear.IsLeapYear("05/05/2001");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestYear2000()
        {
            //Arrange
            FindingALeapYear findingALeapYear = new FindingALeapYear();

            //Act
            var result = findingALeapYear.IsLeapYear("05/05/2000");

            //Assert
            Assert.IsTrue(result);
        }
    }
}
