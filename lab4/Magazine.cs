using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lab4
{
    [TestClass]
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual("Jane Doe", magazine.Author);
            Assert.AreEqual(12, magazine.IssueNumber);
        }

        

    }
}
