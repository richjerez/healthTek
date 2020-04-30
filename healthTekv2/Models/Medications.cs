using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Medications
    {
        public int MedicationsId { get; set; }
        public DateTime MedicationCreatedTs { get; set; }
        public DateTime MedicationModifiedTs { get; set; }
        public string MedicationType { get; set; }
        public string MedicationName { get; set; }
        public string MedicationDescription { get; set; }
        public int FkPrescriptionsId { get; set; }

        public virtual Prescriptions FkPrescriptions { get; set; }
    }
}
