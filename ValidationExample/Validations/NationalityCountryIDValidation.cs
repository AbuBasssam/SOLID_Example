using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class NationalityCountryIDValidation : IValidation<int>
    {
        public bool IsValid(int NationalityCountryID)
        {
            return NationalityCountryID >0 && NationalityCountryID < 194;
        }
    }

}
