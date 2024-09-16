using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample.Interfaces
{
    public interface IPersonRepositary
    {
        bool CheckExistAsync(string NationalNo);

    }
}
