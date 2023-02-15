namespace Task2
{
    internal class PointGenerator
    {
        
        private Random generator;

        public PointGenerator()
        {
            generator = new Random();
        }

        public Point Generate()
        {
            double x = (double)generator.Next(-100, 100);
            double y = (double)generator.Next(-100, 100);
            return new Point(x, y);
        }
    }
}
