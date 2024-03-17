using System.Linq;

namespace NET021.Cathalog
{
    /// <summary>
    /// Dictionary-type collection of Books, with realized specialized methods
    /// </summary>
    public class Cathalog
    {
        /// <summary>
        /// Book dictionary with their ISBN numbers as Keys
        /// </summary>
        public Dictionary<string, Book> BookCathalog { get; private set; }

        /// <summary>
        /// Cathalog construtor
        /// </summary>
        /// <param name="books">Given list of books, which are initializing BookCathalog</param>
        public Cathalog(List<Book> books)
        {
            BookCathalog = new Dictionary<string, Book>();
            foreach (var book in books)
            {
                BookCathalog.Add(book.Title, book);
            }
        }

        /// <summary>
        /// Iterator
        /// </summary>
        /// <returns>BookCathalog, sorted by Titles</returns>
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in BookCathalog.OrderBy(book => book.Value.Title))
            {
                yield return book.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="author">Given Author</param>
        /// <returns>List of all of current Author's Books</returns>
        public List<Book> AuthorBooks(Author author)
        {
            var authorBooks = new List<Book>();
            var selectedBooks = from book in BookCathalog
                                where book.Value.Authors.Contains(new Author(author))
                                select book;

            foreach (var item in selectedBooks)
                authorBooks.Add(item.Value);

            return new List<Book>(authorBooks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>List of Books reverse sorted by Date</returns>
        public List<Book> DateBooks()
        {
            var dateBooks = new List<Book>();
            var selectedBooks = BookCathalog.OrderByDescending(book => book.Value.Date);

            foreach (var item in selectedBooks)
                dateBooks.Add(item.Value);
                                 
            return new List<Book>(dateBooks);                    
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>List of tuples of type (Author, its Books amount) in Cathalog</returns>
        public List<(Author, int)> AuthorsBooksAmount()
        {
            var authorsBooksAmount = new List<(Author, int)>();
            var authors = new List<Author>();

            foreach (var book in BookCathalog)
            {
                foreach (var author in book.Value.Authors)
                {
                    var selectedBooks = from item in BookCathalog
                                        where item.Value.Authors.Contains(author)
                                        select item;

                    if (authors.Count() == 0)
                    {
                        authors.Add(author);
                        authorsBooksAmount.Add((author, selectedBooks.Count()));
                    }

                    else
                    {
                        if (!authors.Contains(author))
                        {
                            authors.Add(author);
                            authorsBooksAmount.Add((author, selectedBooks.Count()));
                        }

                        else continue;
                    }
                }
            }

            return new List<(Author, int)>(authorsBooksAmount);
        }
    }
}
