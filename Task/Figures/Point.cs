﻿using Task.Interfaces;

namespace Task.Figures
{
    /// <summary>
    /// Class for reserving...
    /// </summary>
    public class Point : IMovable
    {
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xCoordinate"></param>
        /// <param name="yCoordinate"></param>
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
                   Math.Abs(XCoordinate - dot.XCoordinate) <= double.Epsilon &&
                   Math.Abs(YCoordinate - dot.YCoordinate) <= double.Epsilon;
        }

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

        public void MoveTo(Point destination)
        {
            XCoordinate = destination.XCoordinate;
            YCoordinate = destination.YCoordinate;
        }

        public void Move(double x, double y)//rename
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