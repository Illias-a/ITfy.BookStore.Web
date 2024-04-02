using ITfy.BookStore.Web.Models;

namespace ITfy.BookStore.Web.Services
{
        public interface IBookService
        {
            Task<List<BookViewModel>> GetAllBooks();
            Task<BookViewModel> GetBookById(int id);
            void CreateBook(BookCreateViewModel model);
            void UpdateBook(BookViewModel model);
        }
}
