using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Tasks
    {
        public int TasksId { get; set; }
        public DateTime TaskCreatedTs { get; set; }
        public DateTime TaskModifiedTs { get; set; }
        public string ScheduledBy { get; set; }
        public string TaskType { get; set; }
        public string TaskStatus { get; set; }
        public string TaskRegarding { get; set; }
        public DateTime? DueDate { get; set; }
        public byte[] TaskAttachment { get; set; }
        public ulong? IsCleared { get; set; }
        public int FkCommentsId { get; set; }
        public int FkUsersId { get; set; }

        public virtual Comments FkComments { get; set; }
        public virtual Users FkUsers { get; set; }
    }
}
