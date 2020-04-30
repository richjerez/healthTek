using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Behaviors
    {
        public Behaviors()
        {
            Goals = new HashSet<Goals>();
            Programs = new HashSet<Programs>();
            Trials = new HashSet<Trials>();
        }

        public int BehaviorsId { get; set; }
        public DateTime BehaviorCreatedTs { get; set; }
        public DateTime BehaviorModifiedTs { get; set; }
        public string BehaviorName { get; set; }
        public string BehaviorDescription { get; set; }
        public DateTime? BehaviorDate { get; set; }
        public sbyte? StoNumMonths { get; set; }
        public sbyte? Baseline { get; set; }
        public int FkClientsId { get; set; }
        public int FkProgramsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Programs FkPrograms { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
        public virtual ICollection<Trials> Trials { get; set; }
    }
}
