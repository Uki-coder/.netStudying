using Task2;

namespace Task2
{
    internal class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public Circle(Circle other)
        {
            Center = other.Center;
            Radius = other.Radius;
        }

        public Circle(Point center, double radius) 
        {
            Center = center;
            Radius = radius;
        }

        public Circle(Point center, Point point)
        {
            Center = center;
            Radius = Center.Distance(point);
        }

        public Circle()
        {
            Random rd = new Random();
            Radius = (double)rd.Next(-100, 100);
            Center = new Point();
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override bool Equals(object? obj)
        {
            return obj is Circle circle &&
                   Center.Equals(circle.Center) &&
                   Math.Abs(Radius - circle.Radius) <= Double.Epsilon;
        }
    }
}
