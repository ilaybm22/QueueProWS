using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class NoConsecutiveRepeatsAttribute : ValidationAttribute
    {
        private readonly int _maxRepeats;

        public NoConsecutiveRepeatsAttribute(int maxRepeats)
        {
            _maxRepeats = maxRepeats;
        }

        public override bool IsValid(object? value)
        {
            if (value is string str && !string.IsNullOrEmpty(str))
            {
                int consecutiveCount = 1;

                for (int i = 1; i < str.Length; i++)
                {
                    if (char.ToLower(str[i]) == char.ToLower(str[i - 1]))
                    {
                        consecutiveCount++;

                        if (consecutiveCount > _maxRepeats)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        consecutiveCount = 1;
                    }
                }
            }

            return true;
        }
    }
}
