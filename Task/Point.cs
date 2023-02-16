namespace Task
{
    internal class Point
    {
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }
        //private double ZCoordinate { get; set; }

        public Point(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            //ZCoordinate = zCoordinate;
        }

        public Point(Point other)
        {
            XCoordinate = other.XCoordinate;
            YCoordinate = other.YCoordinate;
            //ZCoordinate = other.ZCoordinate;
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
            //Math.Abs(ZCoordinate - dot.ZCoordinate) <= Double.Epsilon;
        }

        public double Distance(Point other)
        {
            double xDistance = XCoordinate - other.XCoordinate;
            double yDistance = YCoordinate - other.YCoordinate;
            //double zDistance = ZCoordinate - other.ZCoordinate;

            return Math.Sqrt(
                (xDistance * xDistance) +
                (yDistance * yDistance));
        }
    }
}