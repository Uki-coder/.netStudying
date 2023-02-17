
using System.Drawing;

namespace Task
{
    internal class Circle : Figure
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public Circle(Circle other)
        {
            Center = other.Center;
            Radius = other.Radius;
            Area = other.Area;
            Name = other.Name;
            Color = other.Color;
            Border = other.Border;
            Fill = other.Fill;
        }

        public Circle(Point center, double radius, string color, int border, int fill)
        {
            CheckColor(color);
            Center = center;
            Radius = radius;
            Area = Math.PI * Radius * Radius;
            Name = "circle";
            Color = color;
            Border = (BorderPatterns)border;
            Fill = (FillPatterns)fill;
        }

        public Circle(Point center, Point point, string color, int border, int fill)
        {
            CheckColor(color);
            Center = center;
            Radius = Center.Distance(point);
            Area = Math.PI * Radius * Area;
            Name = "circle";
            Color = color;
            Border = (BorderPatterns)border;
            Fill = (FillPatterns)fill;
        }

        public double GetArea()
        {
            return Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is Circle circle &&
                   Center.Equals(circle.Center) &&
                   Math.Abs(Radius - circle.Radius) <= Double.Epsilon;
        }
    }
}
