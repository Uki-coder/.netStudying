using NET011.IdentificatorClasses;
using NET011.Interfaces;

namespace NET011.TrainingMaterials
{
    public abstract class TrainingMaterial : IThisCloneable
    {

        protected const int DescriptionLength = 256;
        public Identificator MaterialIdentificator { get; protected set; }
        public string Description { get; protected set; }

        public TrainingMaterial()
        {
            Description = "";
            MaterialIdentificator = new Identificator();
        }

        public abstract override bool Equals(object? obj);
        public override string ToString()
        {
            return Description;
        }

        public abstract object Clone();
    }
}
