namespace Task
{
    internal class Fill
    {
        public enum FillPatterns
        {
            None,
            SmallDots,
            Solid,
            Dots,
            Striped,
            WavyStriped,
            HugeDots
        }

        public Color Color { get; set; }
        public FillPatterns Pattern { get; set; }

        public Fill(Color color, int pattern)
        {
            Color = color;
            Pattern = (FillPatterns)pattern;
        }
    }
}
