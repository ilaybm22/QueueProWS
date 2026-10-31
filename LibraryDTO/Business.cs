using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Business
    {
        public string BusinessID { get; set; }

        [Required(ErrorMessage = "business name cannot be empty")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "business name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "business name needs to be in a regular format")]
        [CapitalLetter(ErrorMessage = "business name has to start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string BusinessName { get; set; }

        [Required(ErrorMessage = "home number cannot be empty")]
        [RegularExpression(@"^[1-9]\d{0,3}$", ErrorMessage = "home number must be a valid number")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Home number cannot contain characters repeating too many times in a row")]
        public string HomeNumber { get; set; }

        [Required(ErrorMessage = "phone number cannot be empty")]
        [RegularExpression(@"^0\d{1,2}-?\d{7}$", ErrorMessage = "phone number must be in a valid format (e.g. 03-5551111 or 0501234567)")]
        public string Phone { get; set; } 

        public string HoursID { get; set; }

        [Required(ErrorMessage = "city cannot be empty")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "city name must be between 2 and 30 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "city must contain letters only and start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "City name cannot contain characters repeating too many times in a row")]
        public string City { get; set; }

        public int OwnerID { get; set; }
        public string CategoryID { get; set; }

        [Required(ErrorMessage = "street cannot be empty")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "street name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "street must contain letters only and start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Street name cannot contain characters repeating too many times in a row")]
        public string Street { get; set; }
    }
}
