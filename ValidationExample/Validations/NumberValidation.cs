using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;

namespace ValidationExample.Validation
{
    public class NumberValidation : IValidation<string>
    {
        private IValidation<string> IntegerValidation;
        private IValidation<string> FloatValidation;

        public NumberValidation(IValidation<string> Integer, IValidation<string> Float)
        {
            IntegerValidation = Integer;
            FloatValidation = Float;
        }
        public bool IsValid(string Number)
        {
            return IntegerValidation.IsValid(Number) || FloatValidation.IsValid(Number);


        }
    }
}
