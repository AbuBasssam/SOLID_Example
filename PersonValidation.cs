using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class PersonValidation :IDTOsValidation<PersonDTO>
    {
        //private string ConnectionString;
        IValidation<int> NationalityValidatoin = new NationalityCountryIDValidation();
        IValidation<Object> NullableValidation = new NullableValidtion();
        IValidation<string> EmptyValidation = new EmptyValidation();
        IValidation<string> EmailValidation = new EmailValidation();

        IValidation<string> UniqueNationalNoValidation;
        IValidation<DateTime> UnderAgeValidation = new UnderAgeValidation();
        private string? _ValidationError;
        //private readonly IPersonRepositary _Person;
        private List<string> HasEmptyFileds(PersonDTO Person)
        {
            List<string> EmptyFiledsList = new List<string>();    

            if (EmptyValidation.IsValid(Person.NationalNo))
            {
                EmptyFiledsList.Add( "NationalNo");
            }

            if (EmptyValidation.IsValid(Person.FirstName))
            {
                EmptyFiledsList.Add("FirstName");
                
            }

            if (EmptyValidation.IsValid(Person.SecondName))
            {
                EmptyFiledsList.Add("SecondName");
               
            }

            if (EmptyValidation.IsValid(Person.LastName))
            {
                EmptyFiledsList.Add("LastName");
                
            }

            if (EmptyValidation.IsValid(Person.Address))
            {
                EmptyFiledsList.Add("Address");
            }
           
            if (EmptyValidation.IsValid(Person.Phone))
            {
                EmptyFiledsList.Add("Phone");
            }
           
            return EmptyFiledsList;

        }
       
                
           
        
        public PersonValidation(IPersonRepositary Person)
        {
            
            
            //this._Person = Person;
            UniqueNationalNoValidation =new UniqueNationalNoValidation(Person);
            _ValidationError = null;
        }
        public bool IsValid(PersonDTO PDTO)
        {
            List <string> EmptyFileds = HasEmptyFileds(PDTO);
            if (EmptyFileds.Any()) 
            {
                _ValidationError = "The following fields are required: " +
                          string.Join(", ", EmptyFileds);
                return false;

            }

           
            if (NullableValidation.IsValid(PDTO))
            {
                _ValidationError = "Your object is NULL";
                return false;
            }
           
            if(NationalityValidatoin.IsValid(PDTO.NationalityCountryID))
            {
                _ValidationError = "out of range Nationality ID it's shoud between 1 & 193";
                return false;
            }
            if (UnderAgeValidation.IsValid(PDTO.DateOfBirth))
            {
                _ValidationError = "You're under age";
                return false;
            }
            if(UniqueNationalNoValidation.IsValid(PDTO.NationalNo))
            {
                _ValidationError = $"Person  with NationalNo: {PDTO.NationalNo} already exists";
                return false;

            }
            if (!string.IsNullOrEmpty(PDTO.Email))
            {
               if(!EmailValidation.IsValid(PDTO.Email))
               {
                    _ValidationError = $"Your Email is invalid";
                    return false;

                }
            }
            return true;
        }
        public string? ErrorMessage()
        {
            return this._ValidationError;
            
        }
        

    }
}
