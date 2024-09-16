using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class FloatValidation : IValidation<string>
    {
        public bool IsValid(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }
    }
}
