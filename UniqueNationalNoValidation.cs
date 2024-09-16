using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class UniqueNationalNoValidation:IValidation<string>
    {
        private IPersonRepositary _Person;
        public UniqueNationalNoValidation(IPersonRepositary person)
        {
            _Person = person;
        }
        public bool IsValid(string NationalNo)
        {
            return  _Person.CheckExistAsync(NationalNo);
        }
    }
}
