namespace Task
{
    internal class Point
    {
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }

        public Point(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public Point(Point other)
        {
            XCoordinate = other.XCoordinate;
            YCoordinate = other.YCoordinate;
        }

        public Point()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }
        public override bool Equals(object? obj)
        {
            return obj is Point dot &&
                   Math.Abs(XCoordinate - dot.XCoordinate) <= Double.Epsilon &&
                   Math.Abs(YCoordinate - dot.YCoordinate) <= Double.Epsilon;
        }

        public double Distance(Point other)
        {
            double xDistance = XCoordinate - other.XCoordinate;
            double yDistance = YCoordinate - other.YCoordinate;

            return Math.Sqrt(
                (xDistance * xDistance) +
                (yDistance * yDistance));
        }

        public override string ToString()
        {
            return "Point: " + XCoordinate + ' ' + YCoordinate + '\n';
        }
    }
}