namespace Task
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
                    int hexSym = Generator.Next(48, 70); //ask: neccessity of constants
                    if(!(hexSym >= 58 && hexSym <= 64)) //ask: neccessity of constants
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
            return new Rectangle(leftPoint, rightPoint, GenerateBorder(), GenerateFill()); //ask: how get amount of statements
        }

        public Circle GenerateCircle()
        {
            return new Circle(GeneratePoint(), Generator.Next(0, 100), GenerateBorder(), GenerateFill()); //ask: how get amount of statements

        }

        public Triangle GenerateTriangle()
        {
            return new Triangle(GeneratePoint(), GeneratePoint(), GeneratePoint(), GenerateBorder(), GenerateFill()); //ask: how get amount of statements
        }
    }
}

