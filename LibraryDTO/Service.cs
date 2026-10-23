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
        [NoConsecutiveRepeats(3, ErrorMessage = "Business name cannot contain characters repeating too many times in a row")]
        public string ServiceName { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }


    }
}
