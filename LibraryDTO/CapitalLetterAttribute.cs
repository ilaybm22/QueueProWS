using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class CapitalLetterAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string str = value.ToString();
            char letter = str[0];
            return char.IsUpper(letter);
        }
    }
}
