using System;

/*
 * ProfReynolds
 */

namespace GeometricShapes
{
    public class Triangle : IGeometricShapes
    {
        public int NumberOfSides
        {
            get
            {
                return 3;
            }
        }

        private double _sideLength;
        public double SideLength
        {
            get
            {
                return _sideLength;
            }
            set
            {
                _sideLength = value;
            }
        }

        public double Perimeter()
        {
            return 3 * _sideLength;
        }

        public double Area()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(SideLength, 2);
        }

        public int TotalMeasureOfAllAngles()
        {
            return 180;
        }

        public string Description()
        {
            return $"This Triangle is a {NumberOfSides}-sided geometric shape. Each side is {SideLength} and the area is {Area()}";
        }
    }
}
