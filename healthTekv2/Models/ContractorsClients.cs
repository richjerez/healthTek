using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class ContractorsClients
    {
        public int ClientsId { get; set; }
        public int ContractorsId { get; set; }
        public int FkPersonsId { get; set; }
        public int FkFacilitiesId { get; set; }

        public virtual Facilities FkFacilities { get; set; }
        public virtual Persons FkPersons { get; set; }
    }
}
