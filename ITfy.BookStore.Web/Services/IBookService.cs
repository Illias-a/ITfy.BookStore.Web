using ITfy.BookStore.Web.Models;

namespace ITfy.BookStore.Web.Services
{
    public interface IBookService
    {
        Task<List<BookViewModel>> GetAllBooks();
        Task<BookViewModel> GetBookById(int id);
        Task CreateBook(BookCreateViewModel model);
        Task UpdateBook(BookViewModel model);
    }
}
