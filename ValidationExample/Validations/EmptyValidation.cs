using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class EmptyValidation : IValidation<string?>
    {
        public bool IsValid(string? value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }

}
