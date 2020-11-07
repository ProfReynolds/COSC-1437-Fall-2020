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
    public class NumericExtensionTests
    {
        [Test]
        public void ToInt32Test()
        {
            // arrange unit test
            var testValue = "12";

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(12);
        }
        [Test]
        public void ToInt32Test_1234Condition()
        {
            // arrange unit test
            var testValue = "12.34";

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(-1);
        }
        [Test]
        public void ToInt32Test_2300000000Condition()
        {
            // arrange unit test
            var testValue = "2300000000";

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(-1);
        }
        [Test]
        public void ToInt32Test_TwelveCondition()
        {
            // arrange unit test
            var testValue = "Twelve";

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(-1);
        }
        [Test]
        public void ToInt32Test_NullCondition()
        {
            // arrange unit test
            object testValue = null;

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(-1);
        }
        [Test]
        public void ToInt32Test_0Condition()
        {
            // arrange unit test
            var testValue = 0;

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(0);
        }

        [TestCase(12, 12)]
        [TestCase(12.34, -1)]
        [TestCase(2300000000, -1)]
        [TestCase("Twelve", -1)]
        [TestCase(null, -1)]
        [TestCase(0, 0)]
        public void ToInt32_Test_Comprehensive(object testValue, int expectedResult)
        {
            // arrange unit test
            

            // perform test
            var resultValue = testValue.ToInt32(-1);

            // act the results
            resultValue.ShouldBe(expectedResult);
        }

        [TestCase(12, "12")]
        [TestCase(-1, "-1")]
        [TestCase(0, "0")]
        [TestCase(null, "0")]
        public void ToString_Test_Comprehensive(int testValue, string expectedResult)
        {
            // arrange unit test


            // perform test
            var resultValue = testValue.ToString();

            // act the results
            resultValue.ShouldBe(expectedResult);
        }
    }
}
