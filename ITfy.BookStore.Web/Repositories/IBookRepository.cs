using ITfy.BookStore.Web.Models;

namespace ITfy.BookStore.Web.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        void CreateBookInRepository(Book book);
        void UpdateBookInRepository(Book book);
    }
}
