using NET011.IdentificatorClasses;
using System.ComponentModel;

namespace NET011.TrainingMaterials
{
    public class LinkMaterial : TrainingMaterial
    {
        public enum LinkType
        {
            Unknown = 0,
            Html = 1,
            Image = 2,
            Audio = 3,
            Video = 4
        }
        public string ContentURI { get; private set; }
        public LinkType TypeLink;

        public LinkMaterial (string description, IdentificatorContainer container, string contentURI, LinkType type)
        {
            if (description.Length > DescriptionLength) throw new ArgumentException("Description length is over 256 symbols");

            if (contentURI is null) throw new ArgumentNullException("contentURI", "contentURI is null");
            if (contentURI == "") throw new ArgumentException("contentURI is empty");

            Description = new string(description);
            MaterialIdentificator = new Identificator(container);
            ContentURI = new string(contentURI);
            TypeLink = type;
        }

        private LinkMaterial (string description, Identificator id, string contentURI, LinkType type)
        {
            Description = new string(description);
            MaterialIdentificator = id.Clone();
            ContentURI = new string(contentURI);
            TypeLink = type;
        }

        public override bool Equals(object? obj)
        {
            if (obj is LinkMaterial material &&
                material.MaterialIdentificator.Equals(MaterialIdentificator)) return true;
            else return false;
        }

        public override LinkMaterial Clone()
        {
            return new LinkMaterial(Description, MaterialIdentificator, ContentURI, TypeLink);
        }

    }
}
