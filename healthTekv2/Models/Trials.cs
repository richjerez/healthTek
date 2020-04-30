using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Trials
    {
        public int TrialsId { get; set; }
        public DateTime TrialCreatedTs { get; set; }
        public DateTime TrialModifiedTs { get; set; }
        public sbyte? SuccessfulTrials { get; set; }
        public sbyte? TotalTrials { get; set; }
        public int FkBehaviorsId { get; set; }

        public virtual Behaviors FkBehaviors { get; set; }
    }
}
