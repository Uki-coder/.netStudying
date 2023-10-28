
namespace NET011.IdentificatorClasses 
{
    /// <summary>
    /// Container for Identificators for training instances
    /// </summary>
    public class IdentificatorContainer
    {
        /// <summary>
        /// List for Identificators of traininig instances 
        /// </summary>
        public List<string> IDContainer { get; private set; }

        /// <summary>
        /// Constructor for IdentificatorContainer
        /// </summary>
        public IdentificatorContainer()
        {
            IDContainer = new List<string>();
        }

        public IdentificatorContainer(List<string> idList)
        {
            IDContainer = new List<string>(idList);
        }

        /// <summary>
        /// Checks if Identifiator identificator is contained in current IdentificatorContainer. Returns true in case of containing
        /// </summary>
        /// <param name="identificator">Identificator's IDNumber</param>
        /// <returns></returns>
        public bool CheckIdentificator (string identificator)
        {
            if (IDContainer.Contains(identificator)) return true;
            else return false;
        }

        /// <summary>
        /// Checks for containing Identificator in IdentificatorContainer and adds it to container in case of not containing
        /// </summary>
        /// <param name="identificator">Identificator's IDNumber</param>
        /// <returns></returns>
        public bool AddIdentificator(string identificator)
        {
            if (!CheckIdentificator(identificator))
            {
                IDContainer.Add(identificator);
                return true;
            }

            else return false;
        }

        public object Clone()
        {
            return new IdentificatorContainer(IDContainer);
        }

        //ask about realization
    }
}
