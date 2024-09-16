using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class ValidationService<T>where T : class
    {
         bool IsValid(T Value)
        {
            return false;
        }
    }

}
