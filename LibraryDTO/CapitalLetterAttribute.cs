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
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return true;
            }

            string str = value.ToString()!;

            if (str.Length == 0)
            {
                return true;
            }

            char letter = str[0];
            return char.IsUpper(letter);
        }
    }
}
