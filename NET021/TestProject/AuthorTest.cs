using NET021;

namespace TestProject
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            string wrongName = new string(String.Empty);
            string wrongSurname = new string(String.Empty);

            for (int i = 0; i < 201; i++)
            {
                wrongName += "g";
                wrongSurname += "j";
            }

            Assert.ThrowsException<ArgumentException>(() => { new Author(wrongName, "surname"); });
            Assert.ThrowsException<ArgumentException>(() => { new Author("name", wrongSurname); });
            Assert.ThrowsException<ArgumentException>(() => { new Author(wrongName, wrongSurname); });
        }

        public void EqualsTest()
        {
            Author author1 = new Author("steven", "king");
            Author author = new Author("Steven", "King");

            Assert.IsTrue(author1.Equals(author));
        }
    }
}