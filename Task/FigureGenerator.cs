namespace Task
{
    internal class FigureGenerator
    {

        private Random generator;

        public FigureGenerator()
        {
            generator = new Random();
        }

        public Point GeneratePoint()
        {
            return new Point((double)generator.Next(-100, 100), (double)generator.Next(-100, 100));
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
            return new Rectangle(leftPoint, rightPoint);
        }

        public Circle GenerateCircle()
        {
            return new Circle(GeneratePoint(), (double)generator.Next(-100, 100));

        }

        public Triangle GenerateTriangle()
        {
            return new Triangle(GeneratePoint(), GeneratePoint(), GeneratePoint());
        }
    }
}

