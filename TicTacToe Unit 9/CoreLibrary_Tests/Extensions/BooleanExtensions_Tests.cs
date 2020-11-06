using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class BooleanExtensions_Tests
    {
        [DataTestMethod]
        [DataRow("true", false, true)]
        [DataRow("false", false, false)]
        [DataRow("-1", false, false)]
        [DataRow("-1", true, true)]
        [DataRow(1, false, false)]
        [DataRow(1, true, true)]
        [DataRow(0, false, false)]
        [DataRow(0, true, true)]
        [DataRow(null, false, false)]
        [DataRow(null, true, true)]
        [DataRow("test", false, false)]
        [DataRow("test", true, true)]
        [DataRow("123.45.67", false, false)]
        [DataRow("123.45.67", true, true)]
        [DataRow(true, false, true)]
        [DataRow(false, true, false)]
        public void ToBoolTest(object testValue, bool defaultValue, bool expectedResult)
        {
            // Arrange

            // Act
            bool boolResult = testValue.ToBool(defaultValue);

            // Assert
            boolResult.ShouldBe(expectedResult);
        }

        //[DataTestMethod]
        //[DataRow("true", true)]
        //[DataRow("false", false)]
        //[DataRow("-1", false)]
        //[DataRow(null, false)]
        //[DataRow("test", false)]
        //[DataRow("123.45.67", false)]
        //public void ToBoolTestNoDefault(object testValue, bool expectedResult)
        //{
        //    // Arrange

        //    // Act
        //    bool boolResult = testValue.ToBool();

        //    // Assert
        //    boolResult.ShouldBe(expectedResult);
        //}

        //[DataTestMethod]
        //[DataRow("true", true)]
        //[DataRow("false", false)]
        //[DataRow("-1", null)]
        //[DataRow(null, null)]
        //[DataRow("test", null)]
        //[DataRow("123.45.67", null)]
        //public void ToNullableBoolTest(string testValue, bool? expectedResult)
        //{
        //    // Arrange

        //    // Act
        //    bool? boolResult = testValue.ToNullableBool();

        //    // Assert
        //    boolResult.ShouldBe(expectedResult);
        //}

        //[DataTestMethod]
        //[DataRow(true, "Yes")]
        //public void ToYesNoTest(bool testCase, string expectedResult)
        //{
        //    testCase.ToYesNo().ShouldBe(expectedResult);
        //}

        //[DataTestMethod]
        //[DataRow(null, "")]
        //[DataRow(true, "Yes")]
        //public void ToYesNoNullableTest(bool? testCase, string expectedResult)
        //{
        //    testCase.ToYesNo().ShouldBe(expectedResult);
        //}
    }
}
