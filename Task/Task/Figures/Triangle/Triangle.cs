using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    /// <summary>
    /// Abstract class of triangle that contains 3 points as apexes
    /// </summary>
    public abstract class  Triangle : Figure
    {
        /// <summary>
        /// First apex of triangle
        /// </summary>
        public Point Apex1 { get; protected set; }

        /// <summary>
        /// Second apex of triangle
        /// </summary>
        public Point Apex2 { get; protected set; }

        /// <summary>
        /// Third apex of triangle
        /// </summary>
        public Point Apex3 { get; protected set; }

        /// <summary>
        /// Creates abstract triangle in concrete places
        /// </summary>
        public Triangle()
        {
            Apex1 = new Point();
            Apex2 = new Point();
            Apex3 = new Point();
            MainPoint = Apex1;

            Name = "triangle";
            FigureFill = new Fill(new Color(string.Empty, 0), 0);
            FigureBorder = new Border(new Color(string.Empty, 0), 0);
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

        public override void Shift(double x, double y)
        {
            Apex1.Shift(x, y);
            Apex2.Shift(x, y);
            Apex3.Shift(x, y);

            MainPoint = Apex1;
        }

        /// <summary>
        /// Moves first triangle to the destination point and whole triangle relativelly to first apex
        /// </summary>
        /// <param name="destination">Destination of first apex</param>
        public override void MoveTo(Point destination)
        {
            Apex3.Shift(destination.XCoordinate, destination.YCoordinate);
            Apex2.Shift(destination.XCoordinate, destination.YCoordinate);
            Apex1.MoveTo(destination);

            MainPoint = Apex1;
        }

        public override void MoveHorizontally(double x)
        {
            Apex1.MoveHorizontally(x);
            Apex2.MoveHorizontally(x);
            Apex3.MoveHorizontally(x);

            MainPoint = Apex1;
        }

        public override void MoveVertically(double y)
        {
            Apex1.MoveVertically(y);
            Apex2.MoveVertically(y);
            Apex3.MoveVertically(y);

            MainPoint = Apex1;
        }

        /// <summary>
        /// Moves point during stretching of triangle relativelly to Apex1
        /// </summary>
        /// <param name="apex1">Unmovable Apex1</param>
        /// <param name="apex2">Movable Apex2 or Apex3</param>
        /// <param name="multiplier">Stretching multiplier</param>
        private void StretchMoveApex(Point apex1, Point apex2, double multiplier)
        {
            if (apex1.XCoordinate < apex2.XCoordinate)
                apex2.MoveHorizontally(multiplier * (apex2.XCoordinate - apex1.XCoordinate)
                    - (apex2.XCoordinate - apex1.XCoordinate));

            else if (apex1.XCoordinate > apex2.XCoordinate)
                apex2.MoveHorizontally((apex1.XCoordinate - apex2.XCoordinate)
                    - multiplier * (apex1.XCoordinate - apex2.XCoordinate));

            if (apex1.YCoordinate < apex2.YCoordinate)
                apex2.MoveHorizontally(multiplier * (apex2.YCoordinate - apex1.YCoordinate)
                    - (apex2.YCoordinate - apex1.YCoordinate));

            else if (apex1.YCoordinate > apex2.YCoordinate)
                apex2.MoveHorizontally((apex1.YCoordinate - apex2.YCoordinate)
                    - multiplier * (apex1.YCoordinate - apex2.YCoordinate));
            //ask abput apex1.XYCoordinate == apex2.XYCoordinate

        }

        public override void Stretch(double multiplier)
        {
            if (multiplier <= double.Epsilon)
            {
                throw new ArgumentException("Multiplier is 0 or below", "multiplier");
            }

            StretchMoveApex(Apex1, Apex2, multiplier);
            StretchMoveApex(Apex1, Apex3, multiplier);

            MainPoint = Apex1;
        }
    }
}