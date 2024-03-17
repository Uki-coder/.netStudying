using System.Linq;

namespace NET021
{
    /// <summary>
    /// Author class, describing current Author with his name and surname
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Current author's name, not langer than 200 symbols
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Current author's surname, not langer than 200 symbols
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// Maximum symbol length of name and surname of Author
        /// </summary>
        private const uint MAX_NAME_SURNAME_LENGHT = 200;

        /// <summary>
        /// Author's constructor, initializing its fields with given strings
        /// </summary>
        /// <param name="firstName">Author's name, not langer than 200 symbols</param>
        /// <param name="surname">Author's surname, not langer than 200 symbols</param>
        /// <exception cref="ArgumentException"></exception>
        public Author(string firstName, string surname)
        {
            if (firstName.Length > MAX_NAME_SURNAME_LENGHT)
                throw new ArgumentException("Argument firstName is longer then 200 symbols");
            if (surname.Length > MAX_NAME_SURNAME_LENGHT)
                throw new ArgumentException("Argument surname is longer then 200 symbols");

            FirstName = new string(firstName.ToUpper());
            Surname = new string(surname.ToUpper());

        }

        /// <summary>
        /// Author's constructor, initializing its fields with given author's instance
        /// </summary>
        /// <param name="author"></param>
        public Author(Author author)
        {
            FirstName = new string(author.FirstName.ToUpper());
            Surname = new string(author.Surname.ToUpper());
        }

        /// <summary>
        /// Override method for equals, which compares two Authors
        /// </summary>
        /// <param name="obj">Object to compare</param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Author other &&
                other.FirstName.Equals(FirstName) &&
                other.Surname.Equals(Surname);
        }
    }
}
