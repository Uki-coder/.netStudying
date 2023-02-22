using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Task
{
    internal class Rectangle : Figure
    {
        public Point LeftPoint { get; private set; }
        public Point RightPoint { get; private set; }

        public Rectangle(Point leftPoint, Point rightPoint, Border border, Fill fill)
        {
            LeftPoint = leftPoint;
            RightPoint = rightPoint;
            Name = "rectangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public Rectangle(Rectangle other)
        {
            LeftPoint = other.LeftPoint;
            RightPoint = other.RightPoint;
            Name = other.Name;
            FigureFill = other.FigureFill;
            FigureBorder = other.FigureBorder;
        }

        public override double GetArea()
        {
            Area = Math.Abs(
                (LeftPoint.XCoordinate - RightPoint.XCoordinate) *
                (LeftPoint.YCoordinate - RightPoint.YCoordinate));
            return Area;
        }

        public override bool Equals(object? obj) //ask: equality of fill & border
        {
            return obj is Rectangle rectangle &&
                   LeftPoint.Equals(rectangle.LeftPoint) &&
                   RightPoint.Equals(rectangle.RightPoint);
        }

        public override string ToString()
        {
            return Name + ":\nArea: " + GetArea()
                        + "\nLeft point: " + LeftPoint.XCoordinate + ' ' + LeftPoint.YCoordinate
                        + "\nRight Point: " + RightPoint.XCoordinate + ' ' + RightPoint.YCoordinate
                        + '\n';
        }
    }
}