using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    internal abstract class  Triangle : Figure
    {
        public Point Apex1 { get; protected set; }
        public Point Apex2 { get; protected set; }
        public Point Apex3 { get; protected set; }

        public Triangle()
        {

            Apex1 = new Point();
            Apex2 = new Point();
            Apex3 = new Point();
            Name = "triangle";
            FigureFill = new Fill(new Color(string.Empty, 0), 0);
            FigureBorder = new Border(new Color(string.Empty, 0), 0);
            Area = 0;
        }

        public override bool Equals(object? obj)
        {
            return obj is Triangle triangle &&
                   Apex1.Equals(triangle.Apex1) &&
                   Apex2.Equals(triangle.Apex2) &&
                   Apex3.Equals(triangle.Apex3);
        }

        public abstract override double GetArea();

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