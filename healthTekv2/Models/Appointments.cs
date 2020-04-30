using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Appointments
    {
        public int AppointmentsId { get; set; }
        public DateTime AppointmentCreatedTs { get; set; }
        public DateTime AppointmentModifiedTs { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentStatus { get; set; }
        public TimeSpan? AppointmentStartTime { get; set; }
        public TimeSpan? AppointmentEndTime { get; set; }
        public byte[] AppointmentAttachment { get; set; }
        public int FkClientsId { get; set; }
        public int FkContractorsId { get; set; }
        public int FkCommentsId { get; set; }
        public int FkFacilitiesId { get; set; }
        public int FkLocationsId { get; set; }
        public int FkProceduresId { get; set; }
        public int FkSupervisionsId { get; set; }
        public int FkUsersId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Comments FkComments { get; set; }
        public virtual Contractors FkContractors { get; set; }
        public virtual Facilities FkFacilities { get; set; }
        public virtual Locations FkLocations { get; set; }
        public virtual Procedures FkProcedures { get; set; }
        public virtual Supervisions FkSupervisions { get; set; }
        public virtual Users FkUsers { get; set; }
    }
}
