using ITfy.BookStore.Web.Models;

namespace ITfy.BookStore.Web.Repositories
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books;

        public InMemoryBookRepository()
        {
            _books = new List<Book>
            {
                new Book { Id = 1, Title = "Sample Book 1", Author = "Author 1", Year = 2020 },
                new Book { Id = 2, Title = "Sample Book 2", Author = "Author 2", Year = 2021 },
            };
        }

        public Task<List<Book>> GetAllAsync()
        {
            return Task.FromResult(_books.ToList());
        }

        public Task<Book> GetByIdAsync(int id)
        {
            return Task.FromResult(_books.FirstOrDefault(book => book.Id == id));
        }

        public void CreateBookInRepository(Book book)
        {
            int maxId = _books.Max(book => book.Id);
            book.Id = maxId + 1;

            _books.Add(book);
        }

        public void UpdateBookInRepository(Book book)
        {
            var bookToUpdate = _books.Find(b => b.Id == book.Id);

            if (bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Year = book.Year;
            }
        }
    }

}
