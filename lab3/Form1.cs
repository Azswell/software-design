using System.ComponentModel.Design.Serialization;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }




        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }


        private void ProcessBooks(Book[] Shelf)
        {
            listBox1.Items.Clear();
            foreach (Book book in Shelf)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        public class Ebook : Book
        {
            public int Encoded { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} Year Encoded: ";
            }
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
                Book[] books = new Book[]
                {
                    new Book { Title = "Lord of the Rings", Author = "J.R.R. Tolkein" },
                    new Magazine { Title = "K-ZONE", IssueNumber = 394 },
                    new Ebook { Title = "Harry Potter: Chamber of Secrets", Encoded = 2014 },
                    new Textbook {Title = "Basic Calculus 4th edition", Subject = "Calculus" },
                    new AudioBook {Title = "Dungeon Crawler Carl", Duration = 194, Narrator = "Jeff Hays"}
                };

                ProcessBooks(books);

        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title}, {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public int  Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Duration: {Duration} minutes, Narrated by: {Narrator}";
            }
        }
    }
}
