using Task.Figures.ColorProperties;

namespace Task.Figures
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

        public override bool Equals(object? obj)
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

        public override void Move(double x, double y)
        {
            LeftPoint.Move(x, y);
            RightPoint.Move(x, y);
        }

        public override void MoveTo(Point destination)
        {
            RightPoint.Move(destination.XCoordinate, destination.YCoordinate);
            LeftPoint.MoveTo(destination);
        }

        public override void MoveHorizontally(double x)
        {
            RightPoint.MoveHorizontally(x);
            LeftPoint.MoveHorizontally(x);
        }

        public override void MoveVertically(double y)
        {
            RightPoint.MoveVertically(y);
            LeftPoint.MoveVertically(y);
        }
    }
}