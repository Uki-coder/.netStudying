using Task.Interfaces;

namespace Task.Figures
{
    /// <summary>
    /// Presents point on the plain
    /// </summary>
    public class Point : IMovable
    {
        /// <summary>
        /// Presents point's position on X (horizontal) axis
        /// </summary>
        public double XCoordinate { get; private set; }
        /// <summary>
        /// Presents point's position on Y (vertical) axis
        /// </summary>
        public double YCoordinate { get; private set; }

        /// <param name="xCoordinate">Gives created point its position on X (horizontal) axis</param>
        /// <param name="yCoordinate">Gives created point its position on Y (vertical) axis</param>
        public Point(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        /// <summary>
        /// Gives other point's coordinates and properties to created point
        /// </summary>
        /// <param name="other">Other point which coordinates and properties is given to created point</param>
        public Point(Point other)
        {
            XCoordinate = other.XCoordinate;
            YCoordinate = other.YCoordinate;
        }

        /// <summary>
        /// Creates point in starting point (0,0)
        /// </summary>
        public Point()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }
        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   Math.Abs(XCoordinate - point.XCoordinate) <= double.Epsilon &&
                   Math.Abs(YCoordinate - point.YCoordinate) <= double.Epsilon;
        }

        /// <summary>
        /// Returns distance between point and another point in params
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Distance(Point other)
        {
            double xDistance = XCoordinate - other.XCoordinate;
            double yDistance = YCoordinate - other.YCoordinate;

            return Math.Sqrt(
                xDistance * xDistance +
                yDistance * yDistance);
        }

        public override string ToString()
        {
            return "Point: " + XCoordinate + ' ' + YCoordinate + '\n';
        }

        /// <summary>
        /// Gives currrent point destination point's coordinates
        /// </summary>
        /// <param name="destination">Destination point</param>
        public void MoveTo(Point destination)
        {
            XCoordinate = destination.XCoordinate;
            YCoordinate = destination.YCoordinate;
        }

        public void Shift(double x, double y)
        {
            XCoordinate += x;
            YCoordinate += y;
        }

        public void MoveHorizontally(double x)
        {
            XCoordinate += x;
        }

        public void MoveVertically(double y)
        {
            YCoordinate += y;
        }
    }
}