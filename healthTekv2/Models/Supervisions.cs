using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Supervisions
    {
        public Supervisions()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int SupervisionsId { get; set; }
        public DateTime SupervisionCreatedTs { get; set; }
        public DateTime SupervisionModifiedTs { get; set; }
        public string SupervisionType { get; set; }
        public DateTime? SupervisionDate { get; set; }
        public string SupervisionMode { get; set; }
        public ulong? ClientPresent { get; set; }
        public string SupervisionCharacteristic { get; set; }
        public int FkCommentsId { get; set; }
        public int FkProvidersId { get; set; }

        public virtual Comments FkComments { get; set; }
        public virtual Providers FkProviders { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
