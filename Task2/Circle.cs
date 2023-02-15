using Task2;

namespace Task2
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
        }

        public Circle(Point center, double radius) 
        {
            Center = center;
            Radius = radius;
            Area = Math.PI * Radius * Radius;
        }

        public Circle(Point center, Point point)
        {
            Center = center;
            Radius = Center.Distance(point);
            Area = Math.PI * Radius * Area;
        }

        public Circle()
        {
            Center = new Point();
            Radius = 0.0;
            Area = 0.0;
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
