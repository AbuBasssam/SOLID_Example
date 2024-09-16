using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class NumberValidation : IValidation<String>
    {
        private IValidation<string> IntegerValidation;
        private IValidation<string> FloatValidation;

        public NumberValidation(IValidation<String> Integer, IValidation<String> Float)
        {
            this.IntegerValidation = Integer;
            this.FloatValidation = Float;
        }
        public bool IsValid(String Number)
        {
            return (IntegerValidation.IsValid(Number) || FloatValidation.IsValid(Number));


        }
    }
}
