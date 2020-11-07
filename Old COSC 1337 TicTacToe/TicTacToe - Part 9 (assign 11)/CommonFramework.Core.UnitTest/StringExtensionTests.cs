using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonFramework.Core;
using NUnit;
using NUnit.Framework;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CommonFramework.Core.UnitTest
{
    [TestFixture]
    class StringExtensionTests
    {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("Non empty string", false)]
        public void IsNullOrEmpty_Test(string testValue, bool expectedResult)
        {
            // arrange unit test


            // perform test
            var resultValue = testValue.IsNullOrEmpty();

            // act the results
            resultValue.ShouldBe(expectedResult);
        }

        [TestCase(null, 1, "")]
        [TestCase("", 1, "")]
        [TestCase("This string is 28 characters", 11, "This string")]
        [TestCase("A string", 11, "A string")]
        [TestCase("A string", 0, "")]
        [TestCase("A string", -1, "")]
        public void Left_Test(string testValue, int testLength, string expectedResult)
        {
            // arrange unit test


            // perform test
            var resultValue = testValue.Left(testLength);

            // act the results
            resultValue.ShouldBe(expectedResult);
        }

        [TestCase(null, 1, "")]
        [TestCase("", 1, "")]
        [TestCase("This string is 28 characters", 11, " characters")]
        [TestCase("A string", 11, "A string")]
        [TestCase("A string", 0, "")]
        [TestCase("A string", -1, "")]
        public void Right_Test(string testValue, int testLength, string expectedResult)
        {
            // arrange unit test


            // perform test
            var resultValue = testValue.Right(testLength);

            // act the results
            resultValue.ShouldBe(expectedResult);
        }

    }
}
