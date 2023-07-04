using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace Task.FigureBuilders
{
    internal class FigureGenerator
    {
        public const int HEX_CHAR_AMOUNT = 6;
        private const int FILL_STATEMENTS = 6;
        private const int BORDER_STATEMENTS = 4;
        private Random Generator;

        public FigureGenerator()
        {
            Generator = new Random();
        }

        public Point GeneratePoint()
        {
            return new Point(Generator.Next(-100, 100), Generator.Next(-100, 100));
        }

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

        public Border GenerateBorder()
        {
            return new Border(GenerateColor(), BORDER_STATEMENTS);
        }

        public Fill GenerateFill()
        {
            return new Fill(GenerateColor(), FILL_STATEMENTS);
        }

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

        public Circle GenerateCircle()
        {
            return new Circle(GeneratePoint(), Generator.Next(0, 100), GenerateBorder(), GenerateFill());

        }

        public Triangle GenerateTriangle()
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

            return null;
        }
    }
}

