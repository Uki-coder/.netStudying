﻿namespace Task2
{
    internal class Rectangle : Figure
    {
        public Point LeftPoint { get; private set;}
        public Point RightPoint { get; private set;}

        public Rectangle(Point leftPoint, Point rightPoint)
        {
            LeftPoint = leftPoint;
            RightPoint = rightPoint;
            Area = Math.Abs(
                (LeftPoint.XCoordinate - RightPoint.XCoordinate) *
                (LeftPoint.YCoordinate - RightPoint.YCoordinate));
        }

        public Rectangle(Rectangle other)
        {
            LeftPoint = other.LeftPoint;
            RightPoint = other.RightPoint;
            Area = other.Area;
        }

        public double GetArea()
        {
            return Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   LeftPoint.Equals(rectangle.LeftPoint) &&
                   RightPoint.Equals(rectangle.RightPoint); 
        }
    }
}
