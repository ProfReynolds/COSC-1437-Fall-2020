using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreFramework;
using CoreLibraries;
using Shouldly;

namespace CoreFramework.Tests.Extensions
{
    [TestClass]
    public class StringExtensions_Tests
    {
        #region IsNullOrEmpty

        [TestMethod]
        public void IsNullOrEmpty_IsNull()
        {
            // Arrange
            string testCondition = null;

            // Act
            var actualResult = testCondition.IsNullOrEmpty();

            // Assert
            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsEmpty()
        {
            // Arrange
            string testCondition = string.Empty;

            // Act
            var actualResult = testCondition.IsNullOrEmpty();

            // Assert
            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsSpaces()
        {
            // Arrange
            string testCondition = "   ";

            // Act
            var actualResult = testCondition.IsNullOrEmpty();

            // Assert
            actualResult.ShouldBeFalse();
        }

        [TestMethod]
        public void IsNullOrEmpty_HasContent()
        {
            // Arrange
            string testCondition = "Prof Reynolds";

            // Act
            var actualResult = testCondition.IsNullOrEmpty();

            // Assert
            actualResult.ShouldBeFalse();
        }

        #endregion

        #region IsNullOrWhiteSpace

        [TestMethod]
        public void IsNullOrWhiteSpace_IsNull()
        {
            // Arrange
            string testCondition = null;

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            // Arrange
            string testCondition = string.Empty;

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsSpaces()
        {
            // Arrange
            string testCondition = "   ";

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_HasContent()
        {
            // Arrange
            string testCondition = "Prof Reynolds";

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBeFalse();
        }

        #endregion

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
