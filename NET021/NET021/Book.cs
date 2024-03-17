using System.Text.RegularExpressions;

namespace NET021
{

    /// <summary>
    /// Book class, describing current book's ISBN, title, date of publication and authors
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Enumerator for ISBN format type: 0 for "XXX-X-XX-XXXXXX-X" and 1 "XXXXXXXXXXXXX"
        /// </summary>
        public enum FormatTypes
        {
            Format0 = 0,
            Format1 = 1
        }

        /// <summary>
        /// ISBN format type: 0 for "XXX-X-XX-XXXXXX-X" and 1 "XXXXXXXXXXXXX" 
        /// </summary>
        public FormatTypes FormatType { get; private set; }

        /// <summary>
        /// ISBN id of current book, could be given in "XXX-X-XX-XXXXXX-X" or "XXXXXXXXXXXXX" format, where X - number form 0 to 9
        /// </summary>
        public string ISBN { get; private set; }

        /// <summary>
        /// Title of book, non-null, not longer than 1000 symbols
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Book's date of publication, could be null
        /// </summary>
        public DateOnly Date { get; private set; }

        /// <summary>
        /// Format pattern for "XXX-X-XX-XXXXXX-X"
        /// </summary>
        private const string PATTERN0 = @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}";

        /// <summary>
        /// Format pattern for "XXXXXXXXXXXXX"
        /// </summary>
        private const string PATTERN1 = @"\d{13}";

        /// <summary>
        /// Maximum length of book's title of maximum length is 1000
        /// </summary>
        private const uint TITLE_MAX_LENGTH = 1000;

        /// <summary>
        /// List of Book's Authors  (could be null)
        /// </summary>
        public List<Author> Authors { get; private set; }

        /// <summary>
        /// Book's constructor
        /// </summary>
        /// <param name="isbn">Book's ISBN number, could be given in "XXX-X-XX-XXXXXX-X" or "XXXXXXXXXXXXX" format, where X - number form 0 to 9</param>
        /// <param name="title">Title of book, non-null, not longer than 1000 symbols</param>
        /// <param name="date">Book's date of publication, could be null</param>
        /// <param name="authors">List of Book's Authors, could be null</param>
        /// <exception cref="ArgumentException"></exception>
        public Book(string isbn, string title, DateOnly date, List<Author> authors)
        {
            if (isbn == null)
                throw new NullReferenceException("ISBN is null");

            if (!CheckISBN(isbn, FormatType))
                throw new ArgumentException("Incorrect format of isbn number", "isbn");
            else ISBN = new string(isbn);

            if (title.Length > TITLE_MAX_LENGTH)
                throw new ArgumentException("Title is too long", "title");

            if(title == null)
                throw new NullReferenceException("Title is null");

            Title = new string(title);
            Date = new DateOnly(date.Year, date.Month, date.Day); //ask about date null

            Authors = new List<Author>();

            if (authors == null) Authors = null;
            else foreach (Author author in authors)
                    Authors.Add(new Author(author));

            
        }

        /// <summary>
        /// Method for checking ISBN number's of book accuracy
        /// </summary>
        /// <param name="isbn">Given ISBN</param>
        /// <param name="formatType">Given ISBN format type</param>
        /// <returns></returns>
        private bool CheckISBN(string isbn, FormatTypes formatType)
        {
            if (Regex.IsMatch(isbn, PATTERN0))
            {
                formatType = (FormatTypes)0;
                return true;
            }

            else if (Regex.IsMatch(isbn, PATTERN1))
            {
                formatType = (FormatTypes)1;
                return true;
            }

            else return false;
        }

        /// <summary>
        /// Method for comparing ISBN numbers
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool ISBNCompare(string isbn)
        {
            Regex regex = new Regex(@"\D");
            FormatTypes formatType;
            string newIsbn;

            if (Regex.IsMatch(isbn, PATTERN0)) formatType = (FormatTypes)0;
            else if (Regex.IsMatch(isbn, PATTERN1)) formatType = (FormatTypes)1;    
            else throw new ArgumentException("Incorrect isbn format", "isbn"); //ask

            if (FormatType.Equals(formatType))
            {
                if (ISBN.Equals(isbn)) return true;
                else return false;
            }

            else
            {
                if (formatType == (FormatTypes)0)
                {
                    newIsbn = regex.Replace(isbn, "");
                    if (newIsbn.Equals(ISBN)) return true;
                    else return false;
                }
                else
                {
                    newIsbn = regex.Replace(ISBN, "");
                    if (newIsbn.Equals(isbn)) return true;
                    else return false;
                }
            }
        }

        /// <summary>
        /// Override of Object.Equals(object? obj) method
        /// </summary>
        /// <param name="obj">Given object to compare</param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Book book && ISBNCompare(book.ISBN);
        }
    }
}