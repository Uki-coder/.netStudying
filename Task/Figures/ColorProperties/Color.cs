namespace Task.Figures.ColorProperties
{
    /// <summary>
    /// Presents color
    /// </summary>
    public class Color
    {
        public enum ColorCoding
        {
            TRANSPARENT,
            HEX,
            RGB,
            NAME
        }

        /// <summary>
        /// Gives HEX code, RGB code, color name or null if color is transparent
        /// </summary>
        public string ColorName { get; private set; }
        /// <summary>
        /// Presents way of reserving color's information (as HEX code, RGB code, color name, or transparent)
        /// </summary>
        public ColorCoding Coding { get; private set; }

        /// <summary>
        /// Gives color its properties (coding way and color name)
        /// </summary>
        /// <param name="colorName">Gives color as HEX code, RGB code or name</param>
        /// <param name="coding">Gives color coding way (HEX, RGB, name or TRANSPARENT)</param>
        public Color(string colorName, int coding)
        {
            ColorName = colorName;
            Coding = (ColorCoding)coding;
        }
    }
}
