namespace Task
{
    internal class Triangle : Figure
    {
        public Point Apex1 { get; protected set; }
        public Point Apex2 { get; protected set; }
        public Point Apex3 { get; protected set; }

        public Triangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
            Name = "triangle";
            FigureFill = fill;
            FigureBorder = border;
        }

        public Triangle(Triangle other)
        {
            Apex1 = other.Apex1;
            Apex2 = other.Apex2;
            Apex3 = other.Apex3;
            Name = other.Name;
            FigureBorder = other.FigureBorder;
            FigureFill = other.FigureFill;
        }

        public override bool Equals(object? obj)
        {
            return obj is Triangle triangle &&
                   Apex1.Equals(triangle.Apex1) &&
                   Apex2.Equals(triangle.Apex2) &&
                   Apex3.Equals(triangle.Apex3);
        }

        public override double GetArea()
        {
            double halfPer = (Apex1.Distance(Apex2) + Apex2.Distance(Apex3) + Apex3.Distance(Apex1)) / 2.0;
            Area = Math.Sqrt(halfPer *
                (halfPer - Apex1.Distance(Apex2)) *
                (halfPer - Apex2.Distance(Apex3)) *
                (halfPer - Apex3.Distance(Apex1)));
            return Area;
        }

        public override string ToString()
        {
            return Name + ":\nArea: " + GetArea()
                        + "\nApex1: " + Apex1.XCoordinate + ' ' + Apex1.YCoordinate
                        + "\nApex2: " + Apex2.XCoordinate + ' ' + Apex2.YCoordinate
                        + "\nApex3: " + Apex3.XCoordinate + ' ' + Apex3.YCoordinate
                        + '\n';

        }

        public override void Move(double x, double y)
        {
            Apex1.Move(x, y);
            Apex2.Move(x, y);
            Apex3.Move(x, y);
        }

        public override void MoveTo(Point destination)
        {
            Apex3.Move(destination.XCoordinate, destination.YCoordinate);
            Apex2.Move(destination.XCoordinate, destination.YCoordinate);
            Apex1.MoveTo(destination);
        }

        public override void MoveHorizontally(double x)
        {
            Apex1.MoveHorizontally(x);
            Apex2.MoveHorizontally(x);
            Apex3.MoveHorizontally(x);
        }

        public override void MoveVertically(double y)
        {
            Apex1.MoveVertically(y);
            Apex2.MoveVertically(y);
            Apex3.MoveVertically(y);
        }
    }
}