using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Contractors
    {
        public Contractors()
        {
            Appointments = new HashSet<Appointments>();
            Assignments = new HashSet<Assignments>();
            Papers = new HashSet<Papers>();
            Providers = new HashSet<Providers>();
            Users = new HashSet<Users>();
        }

        public int ContractorsId { get; set; }
        public DateTime ContractorCreatedTs { get; set; }
        public DateTime ContractorModifiedTs { get; set; }
        public string ContractorType { get; set; }
        public decimal? PayRate { get; set; }
        public ulong? IsActive { get; set; }
        public ulong? HrReady { get; set; }
        public string AreaOfResponsibility { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Papers> Papers { get; set; }
        public virtual ICollection<Providers> Providers { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
