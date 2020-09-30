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
            Square square = new Square();

            // Act

            // Assert
            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            // Arrange
            Square square = new Square();
            double expectedValue = 1.2d;

            // Act
            square.SideLength = expectedValue;

            // Assert
            square.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            // Arrange
            Square square = new Square();
            double sideLength = 3.4d;
            double expectedValue = 13.6d;

            // Act
            square.SideLength = sideLength;

            // Assert
            square.Perimeter().ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            // Arrange
            Square square = new Square();
            double sideLength = 5.6d; 
            double expectedArea= 31.36d;

            // Act
            square.SideLength = sideLength;

            // Assert
            square.Area().ShouldBe(expectedArea);
        }
    }
}
