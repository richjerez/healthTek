using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Facilities
    {
        public Facilities()
        {
            Addresses = new HashSet<Addresses>();
            Appointments = new HashSet<Appointments>();
            Assignments = new HashSet<Assignments>();
            Authorizations = new HashSet<Authorizations>();
            ContractorsClients = new HashSet<ContractorsClients>();
            Intakes = new HashSet<Intakes>();
            Invoices = new HashSet<Invoices>();
        }

        public int FacilitiesId { get; set; }
        public DateTime FacilityCreatedTs { get; set; }
        public DateTime FacilityModifiedTs { get; set; }
        public DateTime? DateOfArrival { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string ReferredBy { get; set; }
        public string ReferredIdentifier { get; set; }
        public string Supervisor { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Authorizations> Authorizations { get; set; }
        public virtual ICollection<ContractorsClients> ContractorsClients { get; set; }
        public virtual ICollection<Intakes> Intakes { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
