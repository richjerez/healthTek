using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Policies
    {
        public Policies()
        {
            Authorizations = new HashSet<Authorizations>();
        }

        public int PoliciesId { get; set; }
        public DateTime PolicyCreatedTs { get; set; }
        public DateTime PolicyModifiedTs { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime? PolicyEffDate { get; set; }
        public DateTime? PolicyExpDate { get; set; }
        public int FkClientsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual ICollection<Authorizations> Authorizations { get; set; }
    }
}
