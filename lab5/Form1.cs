using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }

            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }

            public int AuthorId { get; set; }

            public virtual Author Author { get; set; }
        }

        private void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var _context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                _context.Authors.Add(author);
                _context.Books.Add(book);
                _context.SaveChanges();
            }
        }

        private List<string> GetBooksWithAuthors()
        {
            using (var _context = new BookstoreContext())
            {
                var bookWithAuthors = _context.Books
                    .Include(book => book.Author)
                    .Select(book => $"Id[{book.BookId}] {book.Title} by {book.Author.Name}")
                    .ToList();

                return bookWithAuthors;
            }

        }

        private void UpdateBookAndAuthor(int bookId, string newTitle, string authorName)
        {
            using (var _context = new BookstoreContext())
            {
                var book = _context.Books.Include(book => book.Author).FirstOrDefault(book => book.BookId == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = authorName;
                    _context.SaveChanges();
                }
            }
        }

        private void DeleteBookById(int bookId)
        {
            using (var _context = new BookstoreContext())
            {

                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                    MessageBox.Show($"{book.Title} with ID {bookId} has been deleted.");
                }
                else
                {
                    MessageBox.Show("Book ID not found.");
                }
            }
        }

        private List<string> SearchBooksbyAuthor(string authorName)
        {
            using (var _context = new BookstoreContext())
            {
                var books = _context.Books
                    .Include(book => book.Author)
                    .Where(book => book.Author.Name.Contains(authorName))
                    .Select(book => $"Id[{book.BookId}] - {book.Title} by {book.Author.Name}")
                    .ToList();

                return books;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listbxTable.DataSource = books;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(txtbxAuthorName.Text, txtbxBookTitle.Text);
            MessageBox.Show($"{txtbxBookTitle.Text} by {txtbxAuthorName.Text} has been added to the Library");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtbxBookId.Text);
            UpdateBookAndAuthor(bookId, txtbxBookTitle.Text, txtbxAuthorName.Text);
            MessageBox.Show("Book and Author has been updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookid = int.Parse(txtbxDelBookId.Text);
            DeleteBookById(bookid);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtbxSearch.Text;
            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var filteredbooks = SearchBooksbyAuthor(searchName);
                listbxTable.DataSource = filteredbooks;

                if(filteredbooks.Count == 0)
                {
                    MessageBox.Show("No books has been found for this author");
                }
                
            }

        }
    }
}
