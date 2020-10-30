using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class StringExtensions_Tests
    {
        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", false)]
        [DataRow(null, true)]
        [DataRow("Prof Reynolds", false)]
        public void IsNullOrEmpty_Test(string testCondition, bool expectedResult)
        {
            // Arrange
            // no further arrangement required

            // Act
            var actualResult = testCondition.IsNullOrEmpty();

            // Assert
            actualResult.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", true)]
        [DataRow(null, true)]
        [DataRow("Prof Reynolds", false)]
        public void IsNullOrWhiteSpace_Test(string testCondition, bool expectedResult)
        {
            // Arrange
            // no further arrangement required

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow("Prof Reynolds", 8, "Prof Rey")]
        [DataRow("Prof Reynolds", 99, "Prof Reynolds")]
        [DataRow("Prof Reynolds", 0, "")]
        [DataRow(null, 99, null)]
        public void Left_Test(string testCondition, int numCharacters, string expectedResult)
        {
            // Arrange
            // no further arrangement required

            // Act
            var actualResult = testCondition.Left(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: expectedResult);
        }

        [DataTestMethod]
        [DataRow("Prof Reynolds", 8, "Reynolds")]
        [DataRow("Prof Reynolds", 99, "Prof Reynolds")]
        [DataRow("Prof Reynolds", 0, "")]
        [DataRow(null, 99, null)]
        public void Right_Test(string testCondition, int numCharacters, string expectedResult)
        {
            // Arrange
            // no further arrangement required

            // Act
            var actualResult = testCondition.Right(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: expectedResult);
        }
    }
}
