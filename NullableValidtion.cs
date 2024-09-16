using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class NullableValidtion:IValidation<Object>
    {
        public bool IsValid(Object Object)
        {
            return Object==null;
        }
    }
}
