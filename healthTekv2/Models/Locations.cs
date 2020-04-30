using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int LocationsId { get; set; }
        public DateTime LocationCreatedTs { get; set; }
        public DateTime LocationModifiedTs { get; set; }
        public string LocationType { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public int FkProceduresId { get; set; }

        public virtual Procedures FkProcedures { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
