namespace Task
{
    internal class Figure
    {
        public double Area { get; protected set; }
        public string Name { get; protected set; }

       public Figure(double area, string name)
        {
            Area = area;
            Name = name;
        }

        public Figure()
        {
            Area = 0;
            Name = string.Empty;
        }

        public double GetArea() { return Area; }
    }
}