using ITfy.BookStore.Web.Models;
using ITfy.BookStore.Web.Repositories;

namespace ITfy.BookStore.Web.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookViewModel>> GetAllBooks()
        {
            var books = await _bookRepository.GetAllAsync();
            var bookViewModels = books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Year = book.Year
            }).ToList();
            return bookViewModels;
        }

        public async Task<BookViewModel> GetBookById(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null)
            {
                return null;
            }

            var bookViewModel = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Year = book.Year
            };

            return bookViewModel;
        }

        public async Task CreateBook(BookCreateViewModel model)
        {
            var book = new Book
            {
                Title = model.Title,
                Author = model.Author,
                Year = model.Year
            };

            await _bookRepository.CreateBookInRepository(book);
        }

        public async Task UpdateBook(BookViewModel model)
        {
            var book = new Book
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                Year = model.Year
            };

            await _bookRepository.UpdateBookInRepository(book);
        }
    }
}
