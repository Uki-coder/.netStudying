namespace Task
{
    internal class FigureGenerator
    {
        public const int HEX_CHAR_AMOUNT = 6;
        private const int FILL_STATEMENTS = 6;
        private const int BORDER_STATEMENTS = 4;
        private Random generator;

        public FigureGenerator()
        {
            generator = new Random();
        }

        public Point GeneratePoint()
        {
            return new Point((double)generator.Next(-100, 100), (double)generator.Next(-100, 100));
        }

        public string GenerateColor()
        {
            string color = "#";
            for (int i = 0; i < HEX_CHAR_AMOUNT; i++)
            {
                while (true)
                {
                    int hexSym = generator.Next(48, 70); //ask: neccessity of constants
                    if(!(hexSym >= 58 && hexSym <= 64)) //ask: neccessity of constants
                    {
                        color += (char)hexSym;
                        break;
                    }
                }
            }
            return color;
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
            return new Rectangle(leftPoint, rightPoint, GenerateColor(), generator.Next(0, BORDER_STATEMENTS), generator.Next(0, FILL_STATEMENTS)); //ask: how get amount of statements
        }

        public Circle GenerateCircle()
        {
            return new Circle(GeneratePoint(), (double)generator.Next(-100, 100), GenerateColor(), generator.Next(0, BORDER_STATEMENTS), generator.Next(0, FILL_STATEMENTS)); //ask: how get amount of statements

        }

        public Triangle GenerateTriangle()
        {
            return new Triangle(GeneratePoint(), GeneratePoint(), GeneratePoint(), GenerateColor(), generator.Next(0, BORDER_STATEMENTS), generator.Next(0, FILL_STATEMENTS)); //ask: how get amount of statements
        }
    }
}

