namespace ITfy.BookStore.Web.Models
{
    public class BookViewModel
    {
        public required int Id { get; init; }
        public required string Title { get; init; }
        public required string Author { get; init; }
        public required int Year { get; init; }
    }
}
