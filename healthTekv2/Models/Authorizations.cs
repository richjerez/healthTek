using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Authorizations
    {
        public Authorizations()
        {
            Procedures = new HashSet<Procedures>();
        }

        public int AuthorizationsId { get; set; }
        public DateTime AuthorizationCreatedTs { get; set; }
        public DateTime AuthorizationModifiedTs { get; set; }
        public string AuthorizationCode { get; set; }
        public DateTime AuthorizationEffDate { get; set; }
        public DateTime AuthorizationExpDate { get; set; }
        public string AuthorizationNumber { get; set; }
        public string AuthorizationStatus { get; set; }
        public string AuthorizationType { get; set; }
        public int? UnitAmount { get; set; }
        public int? UnitsUsed { get; set; }
        public int FkClientsId { get; set; }
        public int FkFacilitiesId { get; set; }
        public int FkPoliciesId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Facilities FkFacilities { get; set; }
        public virtual Policies FkPolicies { get; set; }
        public virtual ICollection<Procedures> Procedures { get; set; }
    }
}
