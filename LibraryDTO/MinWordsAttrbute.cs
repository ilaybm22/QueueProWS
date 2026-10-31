using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class MinWordsAttribute : ValidationAttribute
    {
        private readonly int _minWords;

        public MinWordsAttribute(int minWords)
        {
            _minWords = minWords;
        }

        public override bool IsValid(object? value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return true;
            }

            if (value is string str)
            {
                string[] words = str.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return words.Length >= _minWords;
            }

            return false;
        }
    }
}
