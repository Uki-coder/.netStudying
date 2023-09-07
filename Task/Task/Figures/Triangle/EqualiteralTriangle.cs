using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    public class EqualiteralTriangle : Triangle
    {
        /// <summary>
        /// Creates equaliteral triangle based on given params
        /// </summary>
        /// <param name="apex1">Gives first apex its position and properties</param>
        /// <param name="apex2">Gives second apex its position and properties</param>
        /// <param name="apex3">Gives third apex its position and properties</param>
        /// <param name="border">Gives border its properties</param>
        /// <param name="fill">Gives fill its properties</param>
        /// <exception cref="ArgumentException">Exception of placing all triangle's apexes placed on one line</exception>
        public EqualiteralTriangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            double LinearKoeff = (apex1.YCoordinate - apex2.YCoordinate) / (apex1.XCoordinate - apex2.XCoordinate);
            double OrdinateKoeff = apex1.YCoordinate - LinearKoeff * apex1.XCoordinate;

            if (Math.Abs(LinearKoeff * apex3.XCoordinate + OrdinateKoeff - apex3.YCoordinate) <= double.Epsilon)
                throw new ArgumentException("All three points are placed on one line");

            if (apex1.Equals(apex2)) throw new ArgumentException("apex1 and apex2 are the same point");
            if (apex1.Equals(apex3)) throw new ArgumentException("apex1 and apex3 are the same point");
            if (apex3.Equals(apex2)) throw new ArgumentException("apex2 and apex3 are the same point");

            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
            Name = "equaliteral triangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            Area = Apex1.Distance(Apex2) * Apex2.Distance(Apex3) * 0.25 * Math.Sqrt(3);
            return Area;
        }

        public override bool Equals(object? obj)
        {
            return obj is EqualiteralTriangle triangle &&
                   Apex1.Equals(triangle.Apex1) &&
                   Apex2.Equals(triangle.Apex2) &&
                   Apex3.Equals(triangle.Apex3);
        }
    }
}
