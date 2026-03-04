using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace lab6
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

        public async Task<List<string>> GetBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(book => book.Author)
                    .Select(book => $"{book.Title} by {book.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBookAsync();
            listBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle };

                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> SearchBooksAsync(string searchTitle, IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress.Report(10); // Start

                var query = context.Books.Include(b => b.Author)
                                         .Where(b => b.Title.Contains(searchTitle));

                progress.Report(50); // Mid-way (Simulated)

                var results = await query.Select(b => $"{b.BookId}: {b.Title} by {b.Author.Name}")
                                         .ToListAsync();

                progress.Report(100); // Complete
                return results;
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        private async Task btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(authorName, bookTitle);

            MessageBox.Show("Book and Author sucessfully saved!");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookstoreContext())
            {
                // Setup the progress reporter
                var progressIndicator = new Progress<int>(percent =>
                {
                    progressBar1.Value = percent;
                });

                listBoxBooks.DataSource = null;

                // Perform search
                var results = await SearchBooksAsync(txtSearch.Text, progressIndicator);

                listBoxBooks.DataSource = results;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int id))
            {
                await DeleteBookAsync(id);
                MessageBox.Show("Book deleted!");
                // Refresh list
                btnFetchBooks_Click(sender, e);
            }
        }
    }
}
