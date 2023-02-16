
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
        }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Area = Math.PI * Radius * Radius;
            Name = "circle";
        }

        public Circle(Point center, Point point)
        {
            Center = center;
            Radius = Center.Distance(point);
            Area = Math.PI * Radius * Area;
            Name = "circle";
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
