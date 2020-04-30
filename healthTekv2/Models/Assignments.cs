using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Assignments
    {
        public int AssignmentsId { get; set; }
        public DateTime AssignmentCreatedTs { get; set; }
        public DateTime AssignmentModifiedTs { get; set; }
        public string AssignmentPosition { get; set; }
        public string AssignmentStatus { get; set; }
        public short? AssignmentCounter { get; set; }
        public DateTime? AssignmentEffDate { get; set; }
        public DateTime? AssignmentExpDate { get; set; }
        public int FkClientsId { get; set; }
        public int FkContractorsId { get; set; }
        public int FkFacilitiesId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Contractors FkContractors { get; set; }
        public virtual Facilities FkFacilities { get; set; }
    }
}
