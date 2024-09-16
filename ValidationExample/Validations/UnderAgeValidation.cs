using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class UnderAgeValidation : IValidation<DateTime>
    {
        public bool IsValid(DateTime DateOfBirth)
        {
            DateTime CompareDate = DateTime.Today.AddYears(-18);
              return DateOfBirth.Date <= CompareDate.Date;
        }
    }
}
