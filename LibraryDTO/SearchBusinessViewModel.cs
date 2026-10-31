using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class SearchBusinessViewModel
    {
        public string? BusinessName { get; set; }

        public int? CategoryId { get; set; }

        public string? City { get; set; }

        public string? Address { get; set; }
    }
}
