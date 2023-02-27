
using System.Drawing;
using Task.Figures.ColorProperties;

namespace Task.Figures
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
            FigureBorder = other.FigureBorder;
            FigureFill = other.FigureFill;
        }

        public Circle(Point center, double radius, Border border, Fill fill)
        {
            Center = center;
            Radius = radius;
            Name = "circle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public Circle(Point center, Point point, Border border, Fill fill)
        {
            Center = center;
            Radius = Center.Distance(point);
            Name = "circle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            Area = Math.PI * Radius * Radius;
            return Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is Circle circle &&
                   Center.Equals(circle.Center) &&
                   Math.Abs(Radius - circle.Radius) <= double.Epsilon;
        }

        public override string ToString()
        {
            return Name + ":\nArea: " + GetArea()
                        + "\nCenter Coordinates: " + Center.XCoordinate + ' ' + Center.YCoordinate
                        + "\nRadius: " + Radius
                        + '\n';
        }

        public override void Move(double x, double y)
        {
            Center.Move(x, y);
        }

        public override void MoveTo(Point destination)
        {
            Center.MoveTo(destination);
        }

        public override void MoveVertically(double y)
        {
            Center.MoveVertically(y);
        }

        public override void MoveHorizontally(double x)
        {
            Center.MoveHorizontally(x);
        }
    }
}
