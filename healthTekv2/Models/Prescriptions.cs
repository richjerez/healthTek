using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Prescriptions
    {
        public Prescriptions()
        {
            Medications = new HashSet<Medications>();
        }

        public int PrescriptionsId { get; set; }
        public DateTime PrescriptionCreatedTs { get; set; }
        public DateTime PrescriptionModifiedTs { get; set; }
        public string PrescriptionIdentifier { get; set; }
        public string PrescriptionFrequency { get; set; }
        public string PrescriptionDuration { get; set; }
        public string PrescriptionDosage { get; set; }
        public int FkClientsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual ICollection<Medications> Medications { get; set; }
    }
}
