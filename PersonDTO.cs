﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class PersonDTO
    {
        public int? PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string? ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string? Email { set; get; }
        public byte NationalityCountryID { set; get; }

        private string? _ImagePath;
        public string? ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public PersonDTO(int? PersonID, string NationalNo, string FirstName, string SecondName
            , string? ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
            string Address, string Phone, string? Email, byte NationalityCountryID, string? ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this._ImagePath = ImagePath;

        }
    }
}
