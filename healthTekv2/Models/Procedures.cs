using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Procedures
    {
        public Procedures()
        {
            Appointments = new HashSet<Appointments>();
            Codes = new HashSet<Codes>();
            Locations = new HashSet<Locations>();
        }

        public int ProceduresId { get; set; }
        public DateTime ProcedureCreatedTs { get; set; }
        public DateTime ProcedureModifiedTs { get; set; }
        public sbyte? ClientDailyLimit { get; set; }
        public sbyte? ContractorDailyLimit { get; set; }
        public string ProcedureName { get; set; }
        public string ProcedureDescription { get; set; }
        public decimal? PremiumAmount { get; set; }
        public short? ProcedureUnits { get; set; }
        public int FkAuthorizationsId { get; set; }
        public int FkClaimsId { get; set; }

        public virtual Authorizations FkAuthorizations { get; set; }
        public virtual Claims FkClaims { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Codes> Codes { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
