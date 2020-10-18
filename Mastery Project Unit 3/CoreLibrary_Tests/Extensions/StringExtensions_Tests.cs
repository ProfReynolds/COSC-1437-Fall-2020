using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {

        #region IsNullOrEmpty

        [TestMethod]
        public void IsNullOrEmpty_IsNull()
        {
            string tCondition = null;

            var actResult = tCondition.IsNullOrEmpty();

            actResult.ShouldBeTrue();
        }


        [TestMethod]
        public void IsNullOrEmpty_IsEmpty()
        {
            string tCondition = "";

            var actResult = tCondition.IsNullOrEmpty();

            actResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsSpaces()
        {
            string tCondition = "   ";

            var actResult = tCondition.IsNullOrEmpty();

            actResult.ShouldBeFalse();
        }

        [TestMethod]
        public void IsNullOrEmpty_HasContent()
        {
            string tCondition = "Jack";

            var actResult = tCondition.IsNullOrEmpty();

            actResult.ShouldBeFalse();
        }

        #endregion


        #region IsNullOrWhiteSpace

        [TestMethod]
        public void IsNullOrWhiteSpace_IsNull()
        {
            string tCondition = null;

            var actResult = tCondition.IsNullOrWhiteSpace();

            actResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            string tCondition = "";

            var actResult = tCondition.IsNullOrWhiteSpace();

            actResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsSpaces()
        {
            string tCondition = "   ";

            var actResult = tCondition.IsNullOrWhiteSpace();

            actResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_HasContent()
        {
            string tCondition = "Jack";

            var actResult = tCondition.IsNullOrWhiteSpace();

            actResult.ShouldBeFalse();
        }

        #endregion

        #region Left

        [TestMethod]
        public void Left_Normal()
        {
            string tCondition = "Jack Ramzel";
            int numChar = 7;

            var actResult = tCondition.Left(numChar);

            actResult.ShouldBe("Jack Ra");
        }

        [TestMethod]
        public void Left_IsNull()
        {
            string tCondition = null;
            int numChar = 3;

            var actResult = tCondition.Left(numChar);

            actResult.ShouldBe(null);
        }

        [TestMethod]
        public void Left_NoCharacters()
        {
            string tCondition = "Jack";
            int numChar = 0;

            var actResult = tCondition.Left(numChar);

            actResult.ShouldBe("");
        }

        [TestMethod]
        public void Left_TooManyCharacters()
        {
            string tCondition = "Jack";
            int numChar = 8;

            var actResult = tCondition.Left(numChar);

            actResult.ShouldBe("Jack");
        }

        #endregion

        #region Right

        [TestMethod]
        public void Right_Normal()
        {
            string tCondition = "Jack Ramzel";
            int numChar = 8;

            var actResult = tCondition.Right(numChar);

            actResult.ShouldBe("k Ramzel");
        }

        [TestMethod]
        public void Right_IsNull()
        {
            string tCondition = null;
            int numChar = 3;

            var actResult = tCondition.Right(numChar);

            actResult.ShouldBe(null);
        }

        [TestMethod]
        public void Right_NoCharacters()
        {
            string tCondition = "Jack";
            int numChar = 0;

            var actResult = tCondition.Right(numChar);

            actResult.ShouldBe("");
        }

        [TestMethod]
        public void Right_TooManyCharacters()
        {
            string tCondition = "Jack";
            int numChar = 8;

            var actResult = tCondition.Right(numChar);

            actResult.ShouldBe("Jack");
        }

        #endregion


    }
}
