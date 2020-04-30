using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Goals
    {
        public Goals()
        {
            Objectives = new HashSet<Objectives>();
            Programs = new HashSet<Programs>();
        }

        public int GoalsId { get; set; }
        public DateTime GoalCreatedTs { get; set; }
        public DateTime GoalModifiedTs { get; set; }
        public string GoalType { get; set; }
        public string GoalName { get; set; }
        public string GoalDescription { get; set; }
        public string GoalStatus { get; set; }
        public int FkBehaviorsId { get; set; }
        public int FkProgramsId { get; set; }
        public int FkClientsId { get; set; }

        public virtual Behaviors FkBehaviors { get; set; }
        public virtual Clients FkClients { get; set; }
        public virtual Programs FkPrograms { get; set; }
        public virtual ICollection<Objectives> Objectives { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
    }
}
