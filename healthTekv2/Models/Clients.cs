using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Appointments = new HashSet<Appointments>();
            Assignments = new HashSet<Assignments>();
            Authorizations = new HashSet<Authorizations>();
            Behaviors = new HashSet<Behaviors>();
            Codes = new HashSet<Codes>();
            Goals = new HashSet<Goals>();
            Intakes = new HashSet<Intakes>();
            Papers = new HashSet<Papers>();
            Policies = new HashSet<Policies>();
            Prescriptions = new HashSet<Prescriptions>();
            Programs = new HashSet<Programs>();
            Relationships = new HashSet<Relationships>();
            Remedies = new HashSet<Remedies>();
        }

        public int ClientsId { get; set; }
        public DateTime ClientCreatedTs { get; set; }
        public DateTime ClientModifiedTs { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Authorizations> Authorizations { get; set; }
        public virtual ICollection<Behaviors> Behaviors { get; set; }
        public virtual ICollection<Codes> Codes { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<Intakes> Intakes { get; set; }
        public virtual ICollection<Papers> Papers { get; set; }
        public virtual ICollection<Policies> Policies { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
        public virtual ICollection<Relationships> Relationships { get; set; }
        public virtual ICollection<Remedies> Remedies { get; set; }
    }
}
