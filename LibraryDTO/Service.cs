using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Service
    {
        public string ServiceID { get; set; }
        public int BusinessID { get; set; }

        [Required(ErrorMessage = "service name cannot be empty")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "service name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "service name must contain letters only and start with a capital letter")]
        [CapitalLetter(ErrorMessage = "service name has to start with a capital letter")]
        [NoConsecutiveRepeats(3, ErrorMessage = "Service name cannot contain characters repeating too many times in a row")]
        public string ServiceName { get; set; }

        [Required(ErrorMessage = "duration cannot be empty")]
        [Range(1, 480, ErrorMessage = "Duration must be between 1 and 480 minutes")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "price cannot be empty")]
        [Range(1, 10000, ErrorMessage = "Price must be a valid positive number")]
        public int Price { get; set; }
    }
}
