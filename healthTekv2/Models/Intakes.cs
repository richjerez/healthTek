using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Intakes
    {
        public int IntakesId { get; set; }
        public DateTime IntakeCreatedTs { get; set; }
        public DateTime IntakeModifiedTs { get; set; }
        public string IntakeStatus { get; set; }
        public DateTime? IntakeEffDate { get; set; }
        public DateTime? IntakeExpDate { get; set; }
        public int FkFacilitiesId { get; set; }
        public int FkClientsId { get; set; }
        public int FkProgramsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Facilities FkFacilities { get; set; }
        public virtual Programs FkPrograms { get; set; }
    }
}
