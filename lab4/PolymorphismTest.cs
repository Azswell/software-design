using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [TestClass]
    public class PolymorphismTest
    {
    

        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
                new Book {Title = "Generic Book", Author = "John Smith"},
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12},
                new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMb = 5 }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5Mb)", books[2].GetInfo());
        }

        [TestMethod]
        public void TestInvalidMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };
        }

        [TestMethod]
        public void TestInvalidBookCreation()
        {
            Book book = new Book { Title = "Invalid", Author = "Invalid" };
        }
        
    }
}
