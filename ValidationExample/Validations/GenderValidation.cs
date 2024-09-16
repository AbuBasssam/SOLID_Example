using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validations
{
    public class GenderValidation:IValidation<int>
    {
        public bool IsValid(int value)
        {
            return( value==0||value==1);
        }
    }
}
