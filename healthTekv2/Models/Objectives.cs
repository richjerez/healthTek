using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Objectives
    {
        public int ObjectivesId { get; set; }
        public DateTime ObjectiveCreatedTs { get; set; }
        public DateTime ObjectiveModifiedTs { get; set; }
        public string ObjectiveType { get; set; }
        public string ObjectiveStatus { get; set; }
        public string ObjectiveNumber { get; set; }
        public string ObjectiveTitle { get; set; }
        public string ObjectiveDescription { get; set; }
        public int FkGoalsId { get; set; }

        public virtual Goals FkGoals { get; set; }
    }
}
