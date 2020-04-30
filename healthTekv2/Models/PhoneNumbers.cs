using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class PhoneNumbers
    {
        public int PhoneNumbersId { get; set; }
        public DateTime PhoneNumberCreatedTs { get; set; }
        public DateTime PhoneNumberModifiedTs { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public int FkPersonsId { get; set; }

        public virtual Persons FkPersons { get; set; }
    }
}
