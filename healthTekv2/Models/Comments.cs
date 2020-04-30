using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Comments
    {
        public Comments()
        {
            Appointments = new HashSet<Appointments>();
            Supervisions = new HashSet<Supervisions>();
            Tasks = new HashSet<Tasks>();
            Users = new HashSet<Users>();
        }

        public int CommentsId { get; set; }
        public DateTime CommentCreatedTs { get; set; }
        public DateTime CommentModifiedTs { get; set; }
        public string CommentTitle { get; set; }
        public string CommentSender { get; set; }
        public string CommentMessage { get; set; }
        public int FkUsersId { get; set; }

        public virtual Users FkUsers { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Supervisions> Supervisions { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
