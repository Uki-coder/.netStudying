using NET011.IdentificatorClasses;
using NET011.Interfaces;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace NET011.TrainingMaterials
{
    public class VideoMaterial : TrainingMaterial, IVersionable
    {
        public List<byte> Version { get; private set; }
        public string VideoContentURI { get; private set; }
        public string PictureURI { get; private set; }

        public enum VideoFormat
        {
            Unknow = 0,
            Mp4 = 1,
            Avi = 2,
            Flv = 3
        }

        public VideoFormat Format { get; private set; }

        public VideoMaterial(string description, IdentificatorContainer container,
            string contentURI, string pictureURI, VideoFormat format, List<byte> version)
        {
            if (description.Length > DescriptionLength) throw new ArgumentException("Description length is over 256 symbols");

            if (pictureURI is null) throw new ArgumentNullException("pictureURI", "puictureURI is null");
            if (pictureURI == "") throw new ArgumentException("pictureURI is empty");
            
            if (contentURI is null) throw new ArgumentNullException("contentURI", "contentURI is null");
            if (contentURI == "") throw new ArgumentException("contentURI is empty");
            
            if (version.Count != 8) throw new ArgumentException("Version List does not contain 8 bytes");

            Description = new string(description);
            MaterialIdentificator = new Identificator(container);
            VideoContentURI = new string(contentURI);
            PictureURI = new string(pictureURI);
            Format = format;
            Version = new List<byte>(version);
        }

        private VideoMaterial(string description, Identificator id, string contentURI, string pictureURI, VideoFormat format, List<byte> version)
        {
            Description = new string(description);
            MaterialIdentificator = id.Clone();
            VideoContentURI = new string(contentURI);
            PictureURI = new string(pictureURI);
            Format = format;
            Version = new List<byte>(version);
        }

        public override bool Equals(object? obj)
        {
            if (obj is VideoMaterial VidMaterial &&
                VidMaterial.MaterialIdentificator.Equals(MaterialIdentificator)) return true;
            else return false;
        }

        public override VideoMaterial Clone()
        {
            return new VideoMaterial(Description, MaterialIdentificator, VideoContentURI, PictureURI, Format, Version);
        }

        public string ReadVersion()
        {
            string VersionString = "";
            for (int i = 0; i < Version.Count; i++)
            {
                VersionString += Convert.ToString(Version[i]);
            }
            return VersionString;
        }

        public void SetVersion(List<byte> versionNew)
        {
            Version = new List<byte>(versionNew);
        }
    }
}
