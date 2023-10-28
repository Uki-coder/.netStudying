using NET011.TrainingMaterials;
using NET011.IdentificatorClasses;
using NET011.Interfaces;

namespace NET011.TrainingLesson
{
    public class TrainingLesson : IThisCloneable, IVersionable
    {
        public List<TrainingMaterial> TrainingMaterialList { get; private set; }
        public List<byte> Version { get; private set; }
        public string Description { get; private set; }
        public Identificator LessonIdentificator { get; private set; }

        public TrainingLesson(List<byte> version, string description, IdentificatorContainer container, List<TrainingMaterial> materials)
        {
            Version = new List<byte>(version); 
            Description = new string(description);
            LessonIdentificator = new Identificator(container);
            TrainingMaterialList = new List<TrainingMaterial>(materials);

        }

        private TrainingLesson(List<byte> version, string description, Identificator id, List<TrainingMaterial> materials)
        {
            Version = new List<byte>(version);
            Description = new string(description);
            LessonIdentificator = id.Clone();
            TrainingMaterialList = new List<TrainingMaterial>();
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i] is TrainingMaterial material)
                    TrainingMaterialList.Add(material);
                else throw new ArgumentException("materials list include non material member");
            }
        }

        public void AddMaterial(TrainingMaterial material)
        {
            TrainingMaterialList.Add(material);
        }

        public object Clone()
        {
            return new TrainingLesson(Version, Description, LessonIdentificator, TrainingMaterialList);
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
