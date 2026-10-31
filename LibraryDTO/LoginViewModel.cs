using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "שדה חובה")]
        [EmailAddress(ErrorMessage = "כתובת אימייל לא תקינה")]
        public string Email { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string Password { get; set; }
    }
}
