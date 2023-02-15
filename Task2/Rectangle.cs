namespace Task2
{
    internal class Rectangle
    {
        public Point Apex1 { get; private set;}
        public Point Apex2 { get; private set;}

        public Rectangle(Point apex1, Point apex2)
        {
            Apex1 = apex1;
            Apex2 = apex2;
        }

        public Rectangle(Rectangle other)
        {
            Apex1 = other.Apex1;
            Apex2 = other.Apex2;
        }

        public Rectangle()
        {
            Apex1 = new Point();
            Apex2 = new Point();
        }

        public double GetArea()
        {
            return Math.Abs(
                (Apex1.XCoordinate - Apex2.XCoordinate) *
                (Apex1.YCoordinate - Apex2.YCoordinate));
        }

        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   ( (Apex1.Equals(rectangle.Apex1) &&
                   Apex2.Equals(rectangle.Apex2) ) ||
                   (Apex1.Equals(rectangle.Apex2) &&
                   Apex2.Equals(rectangle.Apex2)));
        }
    }
}
