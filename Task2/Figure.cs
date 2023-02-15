namespace Task2
{
    internal class Figure
    {
        public double Area { get; protected set; }

        public Figure(double area)
        {
            Area = area;
        }

        public Figure ()
        {
            Area = 0;
        }

        public double GetArea() { return Area; }
    }
}
