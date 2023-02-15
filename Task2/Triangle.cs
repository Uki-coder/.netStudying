﻿using Task2;

namespace Task2
{
    internal class Triangle : Figure
    {
        public Point Apex1 { get; private set; }
        public Point Apex2 { get; private set; }
        public Point Apex3 { get; private set; }

        public Triangle(Point apex1, Point apex2, Point apex3)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;

            double halfPer = (Apex1.Distance(Apex2) + Apex2.Distance(Apex3) + Apex3.Distance(Apex1)) / 2.0;
            Area = Math.Sqrt(halfPer *
                (halfPer - Apex1.Distance(Apex2)) *
                (halfPer - Apex2.Distance(Apex3)) *
                (halfPer - Apex3.Distance(Apex1)));
        }

        public Triangle(Triangle other)
        {
            Apex1 = other.Apex1;
            Apex2 = other.Apex2;
            Apex3 = other.Apex3;
            Area = other.Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is Triangle triangle &&
                   Apex1.Equals(triangle.Apex1) &&
                   Apex2.Equals(triangle.Apex2) &&
                   Apex3.Equals(triangle.Apex3);
        }

        public double GetArea()
        {
            return Area;
        }
    }
}