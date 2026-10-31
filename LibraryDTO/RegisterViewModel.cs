using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "שדה חובה")]
        [CapitalLetter(ErrorMessage = "השם חייב להתחיל באות גדולה")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        [EmailAddress(ErrorMessage = "כתובת אימייל לא תקינה")]
        public string Email { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        [NoConsecutiveRepeats(3, ErrorMessage = "יותר מדי תווים עוקבים זהים")]
        public string Password { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string Phone { get; set; }
    }
}
