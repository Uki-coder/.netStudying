using NET021;
using NET021.Cathalog;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class CathalogTests
    {
        [TestMethod]
        public void CheckEnumerator()
        {
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));

            List<Author> authorList1 = new List<Author>();
            authorList1.Add(new Author("steven", "king"));
            authorList1.Add(new Author("fyodor", "dostoyevski"));

            List<Author> authorList2 = new List<Author>();
            authorList2.Add(new Author("alex", "duma"));

            string ISBN = "1234567890123";
            string ISBN1 = "5678901234567";
            string ISBN2 = "8901234567890";

            DateOnly date = new DateOnly(2005, 6, 12);
            DateOnly date1 = new DateOnly(2003, 6, 12);
            DateOnly date2 = new DateOnly(2000, 6, 12);

            Book book = new Book(ISBN, "nice title", date, authorList);
            Book book1 = new Book(ISBN1, "awesome title", date1, authorList1);
            Book book2 = new Book(ISBN2, "good title", date2, authorList2);

            List<Book> bookList = new List<Book>();
            bookList.Add(book);
            bookList.Add(book1);
            bookList.Add(book2);

            Cathalog cathalog = new Cathalog(bookList);
            List<Book> sortedBooks = new List<Book>();
            foreach(Book booky in cathalog)
            {
                sortedBooks.Add(booky);
            }

            Assert.AreEqual(sortedBooks.Count, 3);
            Assert.IsTrue(sortedBooks[0].Equals(book1));
            Assert.IsTrue(sortedBooks[1].Equals(book2));
            Assert.IsTrue(sortedBooks[2].Equals(book));
        }

        [TestMethod]
        public void CheckAuthorBooks() 
        {
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));

            List<Author> authorList1 = new List<Author>();
            authorList1.Add(new Author("steven", "king"));
            authorList1.Add(new Author("fyodor", "dostoyevski"));

            List<Author> authorList2 = new List<Author>();
            authorList2.Add(new Author("alex", "duma"));

            string ISBN = "1234567890123";
            string ISBN1 = "5678901234567";
            string ISBN2 = "8901234567890";

            DateOnly date = new DateOnly(2005, 6, 12);
            DateOnly date1 = new DateOnly(2003, 6, 12);
            DateOnly date2 = new DateOnly(2000, 6, 12);

            Book book = new Book(ISBN, "nice title", date, authorList);
            Book book1 = new Book(ISBN1, "awesome title", date1, authorList1);
            Book book2 = new Book(ISBN2, "good title", date2, authorList2);

            List<Book> bookList = new List<Book>();
            bookList.Add(book);
            bookList.Add(book1);
            bookList.Add(book2);

            Cathalog cathalog = new Cathalog(bookList);

            List<Book> stevenBooks = new List<Book>(cathalog.AuthorBooks(new Author("Steven", "King")));
            List<Book> alexBooks = new List<Book>(cathalog.AuthorBooks(new Author("alex", "duma")));
            List<Book> fyodorBooks = new List<Book>(cathalog.AuthorBooks(new Author("fyodor", "dostoyevski")));

            Assert.IsTrue(stevenBooks.Count == 2
                && stevenBooks.Contains(book)
                && stevenBooks.Contains(book1)
                && !stevenBooks.Contains(book2));

            Assert.IsTrue(alexBooks.Count == 2
                && alexBooks.Contains(book)
                && alexBooks.Contains(book2)
                && !alexBooks.Contains(book1));

            Assert.IsTrue(fyodorBooks.Count == 1
                && fyodorBooks.Contains(book1));
        }

        [TestMethod]
        public void CheckDateBooks()
        {
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));

            List<Author> authorList1 = new List<Author>();
            authorList1.Add(new Author("steven", "king"));
            authorList1.Add(new Author("fyodor", "dostoyevski"));

            List<Author> authorList2 = new List<Author>();
            authorList2.Add(new Author("alex", "duma"));

            string ISBN = "1234567890123";
            string ISBN1 = "5678901234567";
            string ISBN2 = "8901234567890";

            DateOnly date = new DateOnly(2005, 6, 12);
            DateOnly date1 = new DateOnly(2003, 6, 12);
            DateOnly date2 = new DateOnly(2000, 6, 12);

            Book book = new Book(ISBN, "nice title", date, authorList);
            Book book1 = new Book(ISBN1, "awesome title", date1, authorList1);
            Book book2 = new Book(ISBN2, "good title", date2, authorList2);

            List<Book> bookList = new List<Book>();
            bookList.Add(book);
            bookList.Add(book1);
            bookList.Add(book2);

            Cathalog cathalog = new Cathalog(bookList);

            List<Book> dateBooks = new List<Book>(cathalog.DateBooks());
            Assert.IsTrue(dateBooks.Count == 3
                && dateBooks[0].Equals(book)
                && dateBooks[1].Equals(book1)
                && dateBooks[2].Equals(book2));
        }

        [TestMethod]
        public void CheckAuthorsBooksAmount() 
        {
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));

            List<Author> authorList1 = new List<Author>();
            authorList1.Add(new Author("steven", "king"));
            authorList1.Add(new Author("fyodor", "dostoyevski"));

            List<Author> authorList2 = new List<Author>();
            authorList2.Add(new Author("alex", "duma"));

            string ISBN = "1234567890123";
            string ISBN1 = "5678901234567";
            string ISBN2 = "8901234567890";

            DateOnly date = new DateOnly(2005, 6, 12);
            DateOnly date1 = new DateOnly(2003, 6, 12);
            DateOnly date2 = new DateOnly(2000, 6, 12);

            Book book = new Book(ISBN, "nice title", date, authorList);
            Book book1 = new Book(ISBN1, "awesome title", date1, authorList1);
            Book book2 = new Book(ISBN2, "good title", date2, authorList2);

            List<Book> bookList = new List<Book>();
            bookList.Add(book);
            bookList.Add(book1);
            bookList.Add(book2);

            Cathalog cathalog = new Cathalog(bookList);

            List<(Author, int)> authorAmount = new List<(Author, int)>(cathalog.AuthorsBooksAmount());

            Assert.IsTrue(authorAmount.Contains((new Author("steven", "king"), 2))
                && authorAmount.Contains((new Author("alex", "duma"), 2))
                && authorAmount.Contains((new Author("fyodor", "dostoyevski"), 1)));
        }
    }
}
