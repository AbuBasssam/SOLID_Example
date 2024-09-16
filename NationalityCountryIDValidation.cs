using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class NationalityCountryIDValidation : IValidation<int>
    {
        public bool IsValid(int NationalityCountryID)
        {
            return (NationalityCountryID < 0|| NationalityCountryID >193);
        }
    }
    
}
