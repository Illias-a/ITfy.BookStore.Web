using System.ComponentModel.DataAnnotations;

namespace ITfy.BookStore.Web.Models
{
    public class BookCreateViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Only letters are allowed.")]
        [StringLength(50, ErrorMessage = "Title must be no more than 50 characters")]
        public string Title { get; init; }

        [Required(ErrorMessage = "Author is required")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Only letters are allowed.")]
        [StringLength(50, ErrorMessage = "Author must be no more than 50 characters")]
        public string Author { get; init; }

        [Required(ErrorMessage = "Year is required")]
        [YearRange]
        public int Year { get; init; }
    }
}
