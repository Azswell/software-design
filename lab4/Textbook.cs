using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [TestClass]
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public override string GetInfo()
        {
            return $"{Title}, {Subject}";
        }


        [TestMethod]
        
        public void TestTextBookCreation()
        {
            Textbook textbook = new Textbook { Title = "Invalid", Author = "Invalid", Subject = "Invalid" };
        }
    }
}
