using CoreLibrary.Extensions;
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
        [TestMethod]
        public void IsNullOrEmpty_Test()
        {
            // Arrange
            string testCondition1 = string.Empty;
            string testCondition2 = null;
            string testCondition3 = "ProfReynolds";
            string testCondition4 = "     ";

            // Act
            var actualResult1 = testCondition1.IsNullOrEmpty();
            var actualResult2 = testCondition2.IsNullOrEmpty();
            var actualResult3 = testCondition3.IsNullOrEmpty();
            var actualResult4 = testCondition4.IsNullOrEmpty();

            // Assert
            actualResult1.ShouldBeTrue();
            actualResult2.ShouldBeTrue();
            actualResult3.ShouldBeFalse();
            actualResult4.ShouldBeFalse();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_Test()
        {
            // Arrange
            string testCondition1 = string.Empty;
            string testCondition2 = null;
            string testCondition3 = "ProfReynolds";
            string testCondition4 = "     ";

            // Act
            var actualResult1 = testCondition1.IsNullOrWhiteSpace();
            var actualResult2 = testCondition2.IsNullOrWhiteSpace();
            var actualResult3 = testCondition3.IsNullOrWhiteSpace();
            var actualResult4 = testCondition4.IsNullOrWhiteSpace();

            // Assert
            actualResult1.ShouldBeTrue();
            actualResult2.ShouldBeTrue();
            actualResult3.ShouldBeFalse();
            actualResult4.ShouldBeTrue();
        }

        #region Left

        [TestMethod]
        public void Left_Normal()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 8;

            // Act
            var actualResult = testCondition.Left(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: "Prof Rey");
        }

        [TestMethod]
        public void Left_IsNull()
        {
            // Arrange
            string testCondition = null;
            int numCharacters = 3;

            // Act
            var actualResult = testCondition.Left(numCharacters);

            // Assert
            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Left_NoCharacters()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 0;

            // Act
            var actualResult = testCondition.Left(numCharacters);

            // Assert
            actualResult.ShouldBeEmpty();
        }

        [TestMethod]
        public void Left_TooManyCharacters()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 20;

            // Act
            var actualResult = testCondition.Left(numCharacters);

            // Assert
            actualResult.ShouldNotBeEmpty();
        }

        #endregion

        #region Right

        [TestMethod]
        public void Right_Normal()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 8;

            // Act
            var actualResult = testCondition.Right(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: "Reynolds");
        }

        [TestMethod]
        public void Right_IsNull()
        {
            // Arrange
            string testCondition = null;
            int numCharacters = 3;

            // Act
            var actualResult = testCondition.Right(numCharacters);

            // Assert
            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Right_NoCharacters()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 0;

            // Act
            var actualResult = testCondition.Right(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: string.Empty);
        }

        [TestMethod]
        public void Right_TooManyCharacters()
        {
            // Arrange
            string testCondition = "Prof Reynolds";
            int numCharacters = 20;

            // Act
            var actualResult = testCondition.Right(numCharacters);

            // Assert
            actualResult.ShouldBe(expected: "Prof Reynolds");
        }

        #endregion
    }
}
