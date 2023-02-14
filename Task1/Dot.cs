using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Dot
    {
        private double XCoordinate;
        private double YCoordinate;
        private double ZCoordinate;

        public Dot(double xCoordinate, double yCoordinate, double zCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public Dot()
        {
            XCoordinate = 0.0;
            YCoordinate = 0.0;
            ZCoordinate = 0.0;
        }

        public Dot(Dot other)
        {
            XCoordinate = other.XCoordinate;
            YCoordinate = other.YCoordinate;
            ZCoordinate = other.ZCoordinate;
        }

        public override bool Equals(object? obj)
        {
            return obj is Dot dot &&
                   XCoordinate == dot.XCoordinate &&
                   YCoordinate == dot.YCoordinate &&
                   ZCoordinate == dot.ZCoordinate;
        }

        public double Distance(Dot other)
        {
            double xDistance = XCoordinate - other.XCoordinate;
            double yDistance = YCoordinate - other.YCoordinate;
            double zDistance = ZCoordinate - other.ZCoordinate;

            return Math.Sqrt(
                (xDistance * xDistance) +
                (yDistance * yDistance) +
                (zDistance * zDistance));
        }
    }
}
