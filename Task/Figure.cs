using System.Diagnostics;

namespace Task
{
    internal class Figure
    {
        public enum FillPatterns
        {
            SmallDOts,
            Solid,
            Dots,
            Striped,
            WavyStriped,
            HugeDots,
            None
        }

        public enum BorderPatterns
        {
            Solid,
            Dots,
            Stripes,
            Wavy,
            None
        }

        public double Area { get; protected set; }
        public string Name { get; protected set; } //Type of figure: Circle, Recctangle, Triangle //ask: enum to string
        public string Color { get; protected set; }

        public FillPatterns Fill { get; protected set; }
        public BorderPatterns Border { get; protected set; }

        public Figure()
        {
            Area = 0;
            Name = string.Empty;
            Color = string.Empty;
            Fill = new FillPatterns();
            Border = new BorderPatterns();

        }

        protected void CheckColor(string color)
        {
            for(int i = 58; i < 65; i++) //ask: neccessity of constants
            {
                if (color.Contains((char)i))
                {
                    Console.WriteLine("Exception: wrong argument color");
                    Process.GetCurrentProcess().Kill();
                }
            }
        }

        public double GetArea() { return Area; }
    }
}