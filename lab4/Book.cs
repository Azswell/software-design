using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [TestClass]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }

        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
    }
}
