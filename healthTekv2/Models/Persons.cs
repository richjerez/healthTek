using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Persons
    {
        public Persons()
        {
            Addresses = new HashSet<Addresses>();
            ContractorsClients = new HashSet<ContractorsClients>();
            ESigns = new HashSet<ESigns>();
            PhoneNumbers = new HashSet<PhoneNumbers>();
            Relationships = new HashSet<Relationships>();
        }

        public int PersonsId { get; set; }
        public DateTime PersonCreatedTs { get; set; }
        public DateTime PersonModifiedTs { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string SocialSecNumber { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public sbyte? Age { get; set; }
        public string Religion { get; set; }
        public string Language { get; set; }
        public string Ethnicity { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<ContractorsClients> ContractorsClients { get; set; }
        public virtual ICollection<ESigns> ESigns { get; set; }
        public virtual ICollection<PhoneNumbers> PhoneNumbers { get; set; }
        public virtual ICollection<Relationships> Relationships { get; set; }
    }
}
