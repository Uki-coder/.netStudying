using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace Task.FigureBuilders
{
    /// <summary>
    /// Class for creating randomly generated figures
    /// </summary>
    public class FigureGenerator
    {
        /// <summary>
        /// Amount of symbols in hex code of color
        /// </summary>
        public const int HEX_CHAR_AMOUNT = 6;
        /// <summary>
        /// Amount of statements of fill
        /// </summary>
        private const int FILL_STATEMENTS = 6;
        /// <summary>
        /// Amount of statements of border
        /// </summary>
        private const int BORDER_STATEMENTS = 4;
        /// <summary>
        /// Randomizer of numbers
        /// </summary>
        private Random Generator;

        public FigureGenerator()
        {
            Generator = new Random();
        }

        /// <summary>
        /// Generates random point
        /// </summary>
        /// <returns></returns>
        public Point GeneratePoint()
        {
            return new Point(Generator.Next(-100, 100), Generator.Next(-100, 100));
        }

        /// <summary>
        /// Generates random color in hex coding
        /// </summary>
        /// <returns></returns>
        public Color GenerateColor()
        {
            string color = "#";
            for (int i = 0; i < HEX_CHAR_AMOUNT; i++)
            {
                while (true)
                {
                    int hexSym = Generator.Next(48, 70);
                    if (!(hexSym >= 58 && hexSym <= 64))
                    {
                        color += (char)hexSym;
                        break;
                    }
                }
            }
            return new Color(color, 1);
        }

        /// <summary>
        /// Generates random border pattern
        /// </summary>
        /// <returns></returns>
        public Border GenerateBorder()
        {
            return new Border(GenerateColor(), BORDER_STATEMENTS);
        }

        /// <summary>
        /// Generates random fill pattern
        /// </summary>
        /// <returns></returns>
        public Fill GenerateFill()
        {
            return new Fill(GenerateColor(), FILL_STATEMENTS);
        }

        /// <summary>
        /// Generates random rectangle
        /// </summary>
        /// <returns></returns>
        public Rectangle GenerateRectangle()
        {
            Point leftPoint = new Point(GeneratePoint());
            Point rightPoint = new Point(GeneratePoint());
            while (true)
            {
                if (leftPoint.XCoordinate < rightPoint.XCoordinate && leftPoint.YCoordinate < rightPoint.YCoordinate)
                {
                    break;
                }

                leftPoint = GeneratePoint();
                rightPoint = GeneratePoint();
            }
            return new Rectangle(leftPoint, rightPoint, GenerateBorder(), GenerateFill());
        }

        /// <summary>
        /// Generates random circle
        /// </summary>
        /// <returns></returns>
        public Circle GenerateCircle()
        {
            return new Circle(GeneratePoint(), Generator.Next(0, 100), GenerateBorder(), GenerateFill());

        }

        /// <summary>
        /// Generates random triangle
        /// </summary>
        /// <returns></returns>
        public Figure GenerateTriangle()
        {
            Point apex1 = new Point(GeneratePoint());
            Point apex2 = new Point(GeneratePoint());
            Point apex3 = new Point(GeneratePoint());
            double LinearKoeff, OrdinateKoeff;

            while (true)
            {
                LinearKoeff = (apex1.YCoordinate - apex2.YCoordinate) / (apex1.XCoordinate - apex2.XCoordinate);
                OrdinateKoeff = apex1.YCoordinate - LinearKoeff * apex1.XCoordinate;

                if (!(Math.Abs(LinearKoeff * apex3.XCoordinate + OrdinateKoeff - apex3.YCoordinate) <= double.Epsilon) &&
                    !apex1.Equals(apex2) && !apex2.Equals(apex3) && !apex3.Equals(apex1)) break;
                apex1 = GeneratePoint();
                apex2 = GeneratePoint();
                apex3 = GeneratePoint();
            }

            TriangleBuilder builder = new EqualiteralTriangleBuilder(new IscoscelesTriangleBuilder(
                new RightTriangelBuider(new ArbitraryTriangleBuilder(null))));

            Point[] pointList = { apex1, apex2, apex3 };

            return builder.Build(new List<Point>(pointList), 0, GenerateFill(), GenerateBorder());
        }
    }
}

