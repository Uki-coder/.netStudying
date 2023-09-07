using Task.Figures.ColorProperties;

namespace Task.Figures
{
    /// <summary>
    /// Presents circle on the plain and its properties
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Presents center of circle as a point
        /// </summary>
        public Point Center { get; private set; }
        
        /// <summary>
        /// Radius of Circle
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Creates circle based on given circle:
        ///
        /// With its center position, radius, border and color
        /// </summary>
        /// <param name="other">Given circle that gives properties and properties to created circle</param>
        public Circle(Circle other)
        {
            Center = other.Center;
            Radius = other.Radius;
            Area = other.Area;
            Name = other.Name;
            FigureBorder = other.FigureBorder;
            FigureFill = other.FigureFill;
            MainPoint = other.MainPoint;
        }

        /// <summary>
        /// Creates circle based on the given params
        /// </summary>
        /// <param name="center">Gives center of circle its position and properties</param>
        /// <param name="radius">Gives circle its radius</param>
        /// <param name="border">Gives circle its bordere</param>
        /// <param name="fill">Gives circle its fill</param>
        public Circle(Point center, double radius, Border border, Fill fill)
        {
            Center = center;
            Radius = radius;
            Name = "circle";
            FigureBorder = border;
            FigureFill = fill;

            MainPoint = Center;
        }

        /// <summary>
        /// Creates circle based on given params
        /// </summary>
        /// <param name="center">Gives circle's center its position and properties</param>
        /// <param name="point">The point placed on circle's ring</param>
        /// <param name="border">Gives circle its bordere</param>
        /// <param name="fill">Gives circle its fill</param>
        public Circle(Point center, Point point, Border border, Fill fill)
        {
            Center = center;
            Radius = Center.Distance(point);
            Name = "circle";
            FigureBorder = border;
            FigureFill = fill;

            MainPoint = Center;
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

        public override void Shift(double x, double y)
        {
            Center.Shift(x, y);
            MainPoint = Center;
        }

        /// <summary>
        /// Moves circle's center to destination point and whole circle with
        /// </summary>
        /// <param name="destination">Destination of circle's center</param>
        public override void MoveTo(Point destination)
        {
            Center.MoveTo(destination);
            MainPoint = Center;
        }

        public override void MoveVertically(double y)
        {
            Center.MoveVertically(y);
            MainPoint = Center;
        }

        public override void MoveHorizontally(double x)
        {
            Center.MoveHorizontally(x);
            MainPoint = Center;
        }

        /// <summary>
        /// Stretches circle by multiplying its radius by given number
        /// </summary>
        /// <param name="multiplier">Number by which radius stretches</param>
        public override void Stretch(double multiplier)
        {
            if (multiplier <= double.Epsilon)
            {
                throw new ArgumentException("Multiplier is 0 or below", "multiplier");
            }

            Radius *= multiplier;
        }
    }
}
