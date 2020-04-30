using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Programs
    {
        public Programs()
        {
            Behaviors = new HashSet<Behaviors>();
            Goals = new HashSet<Goals>();
            Intakes = new HashSet<Intakes>();
            Remedies = new HashSet<Remedies>();
        }

        public int ProgramsId { get; set; }
        public DateTime ProgramCreatedTs { get; set; }
        public DateTime ProgramModifiedTs { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }
        public DateTime? ProgramEffDate { get; set; }
        public DateTime? ProgramExpDate { get; set; }
        public int FkBehaviorsId { get; set; }
        public int FkClientsId { get; set; }
        public int FkGoalsId { get; set; }
        public int FkRemediesId { get; set; }

        public virtual Behaviors FkBehaviors { get; set; }
        public virtual Clients FkClients { get; set; }
        public virtual Goals FkGoals { get; set; }
        public virtual Remedies FkRemedies { get; set; }
        public virtual ICollection<Behaviors> Behaviors { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<Intakes> Intakes { get; set; }
        public virtual ICollection<Remedies> Remedies { get; set; }
    }
}
