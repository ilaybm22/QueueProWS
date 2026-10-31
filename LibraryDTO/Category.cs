using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Category
    {
        public string CategoryID { get; set; }

        [Required(ErrorMessage = "category name cannot be empty")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "category name must be between 2 and 30 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "category name needs to be in a regular format")]
        [CapitalLetter(ErrorMessage = "category name has to start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Category name cannot contain characters repeating too many times in a row")]
        public string CategoryName { get; set; }
    }
}
