namespace Task
{
    internal class Border
    {
        public enum BorderPatterns
        {
            None,
            Solid,
            Dots,
            Stripes,
            Wavy,
        }

        public Color Color { get; set; }
        public BorderPatterns Pattern { get; set; }

        public Border(Color color, int pattern)
        {
            Color = color;
            Pattern = (BorderPatterns)pattern;
        }
    }
}
