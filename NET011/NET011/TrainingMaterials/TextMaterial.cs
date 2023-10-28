using NET011.IdentificatorClasses;

namespace NET011.TrainingMaterials
{
    public class TextMaterial : TrainingMaterial
    {
        public string TextBox { get; private set; }
        protected const int TextBoxLimit = 10000;
        public TextMaterial(string description, IdentificatorContainer container, string textBox)
        {
            if (description.Length > DescriptionLength) throw new ArgumentException("Description length is over 256 symbols");
            if (textBox is null) throw new ArgumentNullException("textBox", "textBox is null");
            if (textBox == "") throw new ArgumentException("TextBox is empty");
            if (textBox.Length > TextBoxLimit)
                throw new ArgumentException("Text Box for TextLesson includes too many symbols");

            Description = new string(description);
            MaterialIdentificator = new Identificator(container);
            TextBox = new string(textBox);

        }

        private TextMaterial(string description, Identificator id, string textBox)
        {
            Description = new string(description);
            MaterialIdentificator = id.Clone();
            TextBox = new string(textBox);
        }

        public override bool Equals(object? obj)
        {
            if (obj is TextMaterial textMaterial &&
                textMaterial.MaterialIdentificator.Equals(MaterialIdentificator)) return true;
            else return false;

        }

        public override TextMaterial Clone()
        {
            return new TextMaterial(Description, MaterialIdentificator, TextBox);
        }
    }
}
