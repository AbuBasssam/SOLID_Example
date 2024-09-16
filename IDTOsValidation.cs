using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public interface IDTOsValidation<T> : IValidation<T> where T : class
    {
        string? ErrorMessage();
    }
}
