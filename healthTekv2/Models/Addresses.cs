using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Addresses
    {
        public int AddressesId { get; set; }
        public DateTime AddressCreatedTs { get; set; }
        public DateTime AddressModifiedTs { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public decimal? GpsCoordinates { get; set; }
        public int FkPersonsId { get; set; }
        public int FkFacilitiesId { get; set; }

        public virtual Facilities FkFacilities { get; set; }
        public virtual Persons FkPersons { get; set; }
    }
}
