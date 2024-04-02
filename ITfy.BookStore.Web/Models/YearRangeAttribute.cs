using System.ComponentModel.DataAnnotations;

namespace ITfy.BookStore.Web.Models
{
    public class YearRangeAttribute : ValidationAttribute
    {
        private const int MinYear = 1450;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int year)
            {
                if (year <= MinYear || year > DateTime.Now.Year)
                {
                    return new ValidationResult("The year must be between 1450 and the current year");
                }
            }

            return ValidationResult.Success;
        }
    }
}
