using System.Diagnostics;

namespace Task
{
    internal class Rectangle : Figure
    {
        public Point LeftPoint { get; private set; }
        public Point RightPoint { get; private set; }

        public Rectangle(Point leftPoint, Point rightPoint, string color, int border, int fill)
        {
            CheckColor(color);
            if (!(leftPoint.XCoordinate < rightPoint.XCoordinate && leftPoint.YCoordinate < rightPoint.YCoordinate))
            {
                Console.WriteLine("Exception: wrong arguments leftPoint, RightPoints for Rectangle");
                Process.GetCurrentProcess().Kill();
            }

            LeftPoint = leftPoint;
            RightPoint = rightPoint;
            Name = "rectangle";
            Color = color;
            Border = (BorderPatterns)border;
            Fill = (FillPatterns)fill;
            Area = Math.Abs(
                (LeftPoint.XCoordinate - RightPoint.XCoordinate) *
                (LeftPoint.YCoordinate - RightPoint.YCoordinate));
        }

        public Rectangle(Rectangle other)
        {
            LeftPoint = other.LeftPoint;
            RightPoint = other.RightPoint;
            Area = other.Area;
            Name = other.Name;
            Color = other.Color;
            Fill = other.Fill;
            Border = other.Border;
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