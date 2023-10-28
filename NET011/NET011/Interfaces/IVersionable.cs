using NET011.TrainingMaterials;

namespace NET011.Interfaces
{
    internal interface IVersionable
    {
        public string ReadVersion();
        public void SetVersion(List<byte> versionNew);
    }
}
