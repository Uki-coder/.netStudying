namespace Task.Figures.ColorProperties
{
    /// <summary>
    /// Describes border of figure: its pattern and color
    /// </summary>
    public class Border
    {
        /// <summary>
        /// Describes state of border's pattern: none (transparent), solid, dots, stripes, wavy
        /// </summary>
        public enum BorderPatterns
        {
            None,
            Solid,
            Dots,
            Stripes,
            Wavy,
        }

        /// <summary>
        /// Describes color of fill
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Describes pattern of border
        /// </summary>
        public BorderPatterns Pattern { get; set; }

        /// <summary>
        /// Gives border its properties
        /// </summary>
        /// <param name="color">Gives border's color its properties</param>
        /// <param name="pattern">Gives border's pattern its properties</param>
        public Border(Color color, int pattern)
        {
            Color = color;
            Pattern = (BorderPatterns)pattern;
        }
    }
}
