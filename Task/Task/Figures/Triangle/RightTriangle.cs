using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    public class RightTriangle : Triangle
    {
        /// <summary>
        /// Creates right triangle based on given params
        /// </summary>
        /// <param name="apex1">Gives first apex its position and properties</param>
        /// <param name="apex2">Gives second apex its position and properties</param>
        /// <param name="apex3">Gives third apex its position and properties</param>
        /// <param name="border">Gives border its properties</param>
        /// <param name="fill">Gives fill its properties</param>
        /// <exception cref="ArgumentException">Exception of placing all triangle's apexes placed on one line</exception>
        public RightTriangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            double LinearKoeff = (apex1.YCoordinate - apex2.YCoordinate) / (apex1.XCoordinate - apex2.XCoordinate);
            double OrdinateKoeff = apex1.YCoordinate - LinearKoeff * apex1.XCoordinate;

            double distance12 = apex1.Distance(apex2);
            double distance13 = apex1.Distance(apex3);
            double distance23 = apex2.Distance(apex3);

            if (Math.Abs(LinearKoeff * apex3.XCoordinate + OrdinateKoeff - apex3.YCoordinate) <= double.Epsilon)
                throw new ArgumentException("All three points are placed on one line");

            if (apex1.Equals(apex2)) throw new ArgumentException("apex1 and apex2 are the same point");
            if (apex1.Equals(apex3)) throw new ArgumentException("apex1 and apex3 are the same point");
            if (apex3.Equals(apex2)) throw new ArgumentException("apex2 and apex3 are the same point");

            if (Math.Abs(distance12 * distance12 + distance13 * distance13 - distance23 * distance23) <= double.Epsilon)
            {
                Apex1 = apex1;
                Apex2 = apex2;
                Apex3 = apex3;
            }

            else if (Math.Abs(distance12 * distance12 + distance23 * distance23 - distance13 * distance13) <= double.Epsilon)
            {
                Apex1 = apex2;
                Apex2 = apex1;
                Apex3 = apex3;
            }

            else if (Math.Abs(distance23 * distance23 + distance13 * distance13 - distance12 * distance12) <= double.Epsilon)
            {
                    Apex1 = apex3;
                    Apex2 = apex2;
                    Apex3 = apex1;
            }

            Name = "right triangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            Area = Apex1.Distance(Apex2) * Apex1.Distance(Apex3) * 0.5;
            return Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is RightTriangle triangle &&
                   Apex1.Equals(triangle.Apex1) &&
                   Apex2.Equals(triangle.Apex2) &&
                   Apex3.Equals(triangle.Apex3);
        }
    }
}
