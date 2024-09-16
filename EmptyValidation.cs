using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class EmptyValidation : IValidation<String>
    {
        public bool IsValid(String value)
        {
            return  string.IsNullOrEmpty(value);
        }
    }
    
}
