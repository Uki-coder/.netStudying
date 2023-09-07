using Task.Figures.ColorProperties;

namespace Task.Figures
{
    /// <summary>
    /// Presents rectangle: its properties and position on the plain
    /// 
    /// Creaates rectangle only with its sides parallel to vertical and horizontal axes
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Presents left bottom point of rectangle: its position and properties
        /// </summary>
        public Point LeftPoint { get; private set; }

        /// <summary>
        /// Presents left bottom point of rectangle: its position and properties
        /// </summary>
        public Point RightPoint { get; private set; }

        /// <summary>
        /// Creates rectangle based on given params
        /// </summary>
        /// <param name="leftPoint">Gives to left bottom point of rectangle its positions and properties</param>
        /// <param name="rightPoint">Gives to right bottom point of rectangle its positions and properties</param>
        /// <param name="border">Gives border of rectangle its properties</param>
        /// <param name="fill">Gives fill of rectangle its properties</param>
        /// <exception cref="ArgumentException"></exception>
        public Rectangle(Point leftPoint, Point rightPoint, Border border, Fill fill)
        {
            if (leftPoint.Equals(rightPoint))
                throw new ArgumentException("Given points are the same point");

            else if (Math.Abs(leftPoint.YCoordinate - rightPoint.YCoordinate) <= double.Epsilon)
                throw new ArgumentException("Given points are placed on same vertical line");

            else if (Math.Abs(leftPoint.XCoordinate - rightPoint.XCoordinate) <= double.Epsilon)
                throw new ArgumentException("Given points are placed on same horizontal line");

            LeftPoint = leftPoint;
            RightPoint = rightPoint;
            Name = "rectangle";
            FigureBorder = border;
            FigureFill = fill;

            MainPoint = LeftPoint;
        }

        /// <summary>
        /// Creates rectangle based on given rectangle position and properties
        /// </summary>
        /// <param name="other">Given rectangle that gives properties and properties to created rectangle</param>
        public Rectangle(Rectangle other)
        {
            LeftPoint = other.LeftPoint;
            RightPoint = other.RightPoint;
            Name = other.Name;
            FigureFill = other.FigureFill;
            FigureBorder = other.FigureBorder;
            MainPoint = other.MainPoint;
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

        public override void Shift(double x, double y)
        {
            LeftPoint.Shift(x, y);
            RightPoint.Shift(x, y);

            MainPoint = LeftPoint;
        }

        /// <summary>
        /// Moves left bottom point of rectangle to the destination point and whole rectangle relativelly to left bottom point
        /// </summary>
        /// <param name="destination">Destination of left bottom point of rectangle</param>
        public override void MoveTo(Point destination)
        {
            RightPoint.Shift(destination.XCoordinate, destination.YCoordinate);
            LeftPoint.MoveTo(destination);

            MainPoint = LeftPoint;

        }

        public override void MoveHorizontally(double x)
        {
            RightPoint.MoveHorizontally(x);
            LeftPoint.MoveHorizontally(x);

            MainPoint = LeftPoint;
        }

        public override void MoveVertically(double y)
        {
            RightPoint.MoveVertically(y);
            LeftPoint.MoveVertically(y);

            MainPoint = LeftPoint;
        }

        public override void Stretch(double multiplier)
        {
            if (multiplier <= double.Epsilon)
            {
                throw new ArgumentException("Multiplier is 0 or below", "multiplier");
            }

            RightPoint.MoveVertically(multiplier * (RightPoint.YCoordinate - LeftPoint.YCoordinate) -
                    RightPoint.YCoordinate - LeftPoint.YCoordinate);

            RightPoint.MoveHorizontally(multiplier * (RightPoint.XCoordinate - LeftPoint.XCoordinate) -
                RightPoint.XCoordinate - LeftPoint.XCoordinate);

            MainPoint = LeftPoint;
        }
    }
}