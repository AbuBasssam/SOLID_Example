using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class NullableValidtion : IValidation<object>
    {
        public bool IsValid(object Object)
        {
            return Object != null;
        }
    }
}
