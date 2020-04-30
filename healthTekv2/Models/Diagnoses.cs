using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Diagnoses
    {
        public int DiagnosesId { get; set; }
        public DateTime DiagnosisCreatedTs { get; set; }
        public DateTime DiagnosisModifiedTs { get; set; }
    }
}
