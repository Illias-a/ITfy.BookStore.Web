using ITfy.BookStore.Web.Models;
using ITfy.BookStore.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITfy.BookStore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllBooks();
            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookService.GetBookById(id);

            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _bookService.CreateBook(model);

            return Redirect("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            BookViewModel model = await _bookService.GetBookById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(BookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _bookService.UpdateBook(model);
            
            return RedirectToAction("Details", "Book", new { id = model.Id });
        }
    }
}
