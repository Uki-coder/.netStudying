namespace Task
{
    internal abstract class Figure
    {
       
        public double Area { get; protected set; }
        public string Name { get; protected set; } //Type of figure: Circle, Recctangle, Triangle //ask: enum to string
        public Border FigureBorder { get; protected set; }
        public Fill FigureFill { get; protected set; }


        public Figure()
        {
            Area = 0;
            Name = string.Empty;
            FigureBorder = new Border(new Color("", 0), 0);
            FigureFill = new Fill(new Color("", 0), 0);
        }

        public abstract double GetArea();
        public abstract override string ToString();
    }
}