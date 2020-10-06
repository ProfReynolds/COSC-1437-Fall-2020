using System;
using System.Collections.Generic;
using System.Text;
using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Square_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_4()
        {
            // Arrange
            var square = new Square();

            // Act

            // Assert
            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            // Arrange
            var square = new Square();
            var expectedValue = 1.2d;

            // Act
            square.SideLength = expectedValue;

            // Assert
            square.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            // Arrange
            var square = new Square();
            var sideLength = 3.4d;
            var expectedValue = 13.6d;

            // Act
            square.SideLength = sideLength;

            // Assert
            square.Perimeter().ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            // Arrange
            var square = new Square();
            var sideLength = 5.6d; 
            var expectedArea= 31.36d;
            var expectedAreaMinimumAcceptable = expectedArea - .001d;
            var expectedAreaMaximumAcceptable = expectedArea + .001d;

            // Act
            square.SideLength = sideLength;

            // Assert
            square.Area().ShouldBeInRange(expectedAreaMinimumAcceptable, expectedAreaMaximumAcceptable);
        }

        [TestMethod]
        public void Verify_TotalMeasureOfAllAngles_Is_Calculated_Accurately()
        {
            // Arrange
            var square = new Square();

            // Act

            // Assert
            square.TotalMeasureOfAllAngles().ShouldBe(360);
        }

        [TestMethod]
        public void Verify_The_Description_Returns_Value()
        {
            // Arrange
            var square = new Square();

            // Act

            // Assert
            square.Description().ShouldNotBeNullOrWhiteSpace();
        }
    }
}
