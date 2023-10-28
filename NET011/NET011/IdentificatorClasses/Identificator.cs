using NET011.Interfaces;

namespace NET011.IdentificatorClasses
{
    /// <summary>
    /// Creates unique 16-symbol ID which includes numbers and letters from A to F for each instance of training
    /// </summary>
    public class Identificator
    {
        /// <summary>
        /// String container for ID
        /// </summary>
        public string IDNumber { get; private set; }
        /// <summary>
        /// Randomazer, that generates symbols for IDNumber
        /// </summary>
        private Random SymbolMaker;

        /// <summary>
        /// Constructor class for identificator
        /// </summary>
        /// <param name="identificatorContainer"> Current IdentificatorContainer for current instance</param>
        public Identificator (IdentificatorContainer identificatorContainer)
        {
            SymbolMaker = new Random();
            
            while (true)
            {
                if (Convert.ToBoolean(SymbolMaker.Next(0, 2)))
                    //adds number symbol to IDNumber
                    IDNumber = IDNumber + Convert.ToChar(SymbolMaker.Next(48, 58)); 
                else
                    //adds letter symbol to IDNUMBER
                    IDNumber = IDNumber + Convert.ToChar(SymbolMaker.Next(65, 71));

                if (IDNumber.Length == 16)
                {
                    if (identificatorContainer.AddIdentificator(IDNumber)) break;
                    else IDNumber = "";
                }
            }
        }

        public Identificator()
        {
            IDNumber = "";
            SymbolMaker = new Random();
        }

        private Identificator(string number)
        {
            IDNumber = number;
            SymbolMaker = new Random();
        }

        /// <summary>
        /// Override Equals for Identificator class
        /// </summary>
        /// <param name="obj">Comparable object</param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Identificator identificator &&
                identificator.IDNumber.Equals(IDNumber);
        }

        /// <summary>
        /// Override ToString for Identificators class. Returns IDNumber
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return IDNumber;
        }

        public Identificator Clone() => new Identificator(IDNumber);
    }
}
