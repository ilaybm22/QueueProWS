using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class ReviewViewModel
    {
        public int BusinessId { get; set; }

        public int UserId { get; set; }

        [Range(1, 5, ErrorMessage = "הדירוג חייב להיות בין 1 ל-5")]
        public int Rating { get; set; }

        [StringLength(500, ErrorMessage = "חוות הדעת אינה יכולה לעלות על 500 תווים")]
        public string Comment { get; set; }
    }
}
