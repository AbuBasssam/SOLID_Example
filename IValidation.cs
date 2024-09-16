using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public interface IValidation<T>
    {
        bool IsValid(T Value);
    }
}
