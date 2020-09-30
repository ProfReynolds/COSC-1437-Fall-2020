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
    public class Pentagon_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_5()
        {
            // Arrange
            Pentagon pentagon = new Pentagon();

            // Act

            // Assert
            pentagon.NumberOfSides.ShouldBe(5);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            // Arrange
            Pentagon pentagon = new Pentagon();
            double expectedValue = 1.2d;

            // Act
            pentagon.SideLength = expectedValue;

            // Assert
            pentagon.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            // Arrange
            Pentagon pentagon = new Pentagon();
            double sideLength = 3.4d;
            double expectedValue = 17d;

            // Act
            pentagon.SideLength = sideLength;

            // Assert
            pentagon.Perimeter().ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            // Arrange
            Pentagon pentagon = new Pentagon();
            double sideLength = 5.6d; //resulting area = approx 53.95
            double expectedAreaMinimumAcceptable = 53.945d;
            double expectedAreaMaximumAcceptable = 53.955d;

            // Act
            pentagon.SideLength = sideLength;

            // Assert
            pentagon.Area().ShouldBeInRange(expectedAreaMinimumAcceptable, expectedAreaMaximumAcceptable);
        }
    }
}
