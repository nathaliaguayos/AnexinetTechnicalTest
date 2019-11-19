using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2ndExercise_RepeatedChars;

namespace _2ndExercise_RepeatedCharsTests
{
    [TestClass]
    public class RepeatedCharactersTest
    {
        [TestMethod]
        public void TestFirsScenario()
        {
            //Arrange
            string firstString = "hjndx";
            string secondString = "kundx";
            char[] expected = { 'n', 'd', 'x' };
            RepeatedCharacters repeatedChars = new RepeatedCharacters();

            //Act
            var result = repeatedChars.FindRepeatedCharacters(firstString, secondString);

            //Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestSecondScenario()
        {
            //Arrange
            string firstString = "qjzxsvot";
            string secondString = "jpxmsbt";
            char[] expected = { 'j', 'x', 's', 't' };
            RepeatedCharacters repeatedChars = new RepeatedCharacters();

            //Act
            var result = repeatedChars.FindRepeatedCharacters(firstString, secondString);

            //Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
