using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class User
    {
        public string UserID { get; set; }
        [Required(ErrorMessage = "full name cannot be empty")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "full name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "full name needs to be in a regular format")]
        [CapitalLetter(ErrorMessage = "full name has to start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "phone number cannot be empty")]
        [RegularExpression(@"^0\d{1,2}-?\d{7}$", ErrorMessage = "phone number must be in a valid format (e.g. 03-5551111 or 0501234567)")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "email cannot be empty")]
        [EmailAddress(ErrorMessage = "email must be in a valid email format")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string Email { get; set; }
        [Required(ErrorMessage = "password cannot be empty")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "password must be at least 6 characters long")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string Password { get; set; }

    }
}
