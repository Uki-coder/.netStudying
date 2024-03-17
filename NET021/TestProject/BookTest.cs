using NET021;

namespace TestProject
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            DateOnly date = new DateOnly();
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));
            string ISBN = "1234567890123";
            string ISBN1 = "123-4-56-789012-3";
            string wrongISBN = "askjn287887";
            string longTitle = "";
            for (int i = 0; i < 1001; i++)
            {
                longTitle += "j";
            }

            Assert.ThrowsException<NullReferenceException>(() => { new Book(null, "asfa", date, authorList); });
            Assert.ThrowsException<ArgumentException>(() => { new Book(wrongISBN, "asfa", date, authorList); });
            Assert.ThrowsException<ArgumentException>(() => { new Book(ISBN, longTitle, date, authorList); });
            Assert.ThrowsException<NullReferenceException>(() => { new Book(ISBN, null, date, authorList); });

            Book book = new Book(ISBN, "adsad", date, authorList);
            Book book1 = new Book(ISBN1, "adsad", date, authorList);

            Assert.IsTrue(book is Book);
            Assert.IsTrue(book1 is Book);
        }

        [TestMethod]
        public void EqualsTest()
        {
            DateOnly date = new DateOnly();
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("steven", "king"));
            authorList.Add(new Author("alex", "duma"));
            string ISBN = "1234567890123";
            string ISBN1 = "123-4-56-789012-3";

            Book book = new Book(ISBN, "asjdbjkb", date, authorList);
            Book book1 = new Book(ISBN1, "asjdbjkb", date, authorList);
            Assert.IsTrue(book1.Equals(book));
        }
    }
}
