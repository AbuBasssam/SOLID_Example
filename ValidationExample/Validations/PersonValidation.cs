using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationExample.Interfaces;
using ValidationExample.Person;

namespace ValidationExample.Validation
{
    public class PersonValidation : IDTOsValidation<PersonDTO>
    {
        private string? _ValidationError;

        private readonly IPersonRepositary _Person;

        private List<string> HasEmptyFileds(PersonDTO Person)
        {
            IValidation<string?> EmptyValidation = new EmptyValidation();

            List<string> EmptyFiledsList = new List<string>();

            if (!EmptyValidation.IsValid(Person.NationalNo))
            {
                EmptyFiledsList.Add("NationalNo");
            }

            if (!EmptyValidation.IsValid(Person.FirstName))
            {
                EmptyFiledsList.Add("FirstName");

            }

            if (!EmptyValidation.IsValid(Person.SecondName))
            {
                EmptyFiledsList.Add("SecondName");

            }

            if (!EmptyValidation.IsValid(Person.LastName))
            {
                EmptyFiledsList.Add("LastName");

            }

            if (!EmptyValidation.IsValid(Person.Address))
            {
                EmptyFiledsList.Add("Address");
            }

            if (!EmptyValidation.IsValid(Person.Phone))
            {
                EmptyFiledsList.Add("Phone");
            }

            return EmptyFiledsList;

        }

        public PersonValidation(IPersonRepositary Person)
        {
            _Person = Person;
            _ValidationError = null;
        }

        public bool IsValid(PersonDTO PDTO)
        {
            //Empty Validatoin
            List<string> EmptyFileds = HasEmptyFileds(PDTO);
            if (EmptyFileds.Any())
            {
                _ValidationError = "The following fields are required: " +
                          string.Join(", ", EmptyFileds);
                return false;

            }

            //_____________________________________________________________________

            // Nullable Validatoin
            IValidation<object> NullableValidation = new NullableValidtion();
            if (!NullableValidation.IsValid(PDTO))
            {
                _ValidationError = "Your object is NULL";
                return false;
            }

            //_____________________________________________________________________

            //Nationality Validatoin
            IValidation<int> NationalityValidatoin = new NationalityCountryIDValidation();
            if (!NationalityValidatoin.IsValid(PDTO.NationalityCountryID))
            {
                _ValidationError = "out of range Nationality ID it's shoud between 1 & 193";
                return false;
            }

            //_____________________________________________________________________

            //Under age Validation
            IValidation<DateTime> UnderAgeValidation = new UnderAgeValidation();
            if (!UnderAgeValidation.IsValid(PDTO.DateOfBirth))
            {
                _ValidationError = "You're under age";
                return false;
            }

            //_____________________________________________________________________

            // Unique NationalNo Validation
            IValidation<string> UniqueNationalNoValidation = new UniqueNationalNoValidation(_Person); ;
            if (!UniqueNationalNoValidation.IsValid(PDTO.NationalNo))
            {
                _ValidationError = $"Person  with NationalNo: {PDTO.NationalNo} already exists";
                return false;

            }

            //_____________________________________________________________________

            // Email Validation
            IValidation<string?> EmptyValidation = new EmptyValidation();
            if (!EmptyValidation.IsValid(PDTO.Email!))
            {
                IValidation<string> EmailValidation = new EmailValidation();

                if (!EmailValidation.IsValid(PDTO.Email!))
                {
                    _ValidationError = $"Your Email is invalid";
                    return false;

                }
            }
            return true;
        }

        public string? ErrorMessage()
        {
            return _ValidationError;

        }


    }
}
