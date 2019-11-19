using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4thExercise_BalancedBrackets;

namespace _4thExercise_BalancedBracketsTests
{
    [TestClass]
    public class BracketsEvaluatorTest
    {
       
        [TestMethod]
        public void TestRightInput()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "(([{{}}])){}[]";

            //Assert
            Assert.IsTrue(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestRightInput2()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "<(([{{}}])){}[]<[{}]>>";

            //Assert
            Assert.IsTrue(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInput()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "(([])){<}>";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInput2()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "(([])){<}>";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInputExample1()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "(((";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInputExample2()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "(]";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInputExample3()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "()(";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
        [TestMethod]
        public void TestWrongInputExample4()
        {
            //Arrange
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            //Act
            string stringToValidate = "([)]";

            //Assert
            Assert.IsFalse(bracketsEvaluator.AreBracketsBalanced(stringToValidate));
        }
    }
}
