using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Users
    {
        public Users()
        {
            Appointments = new HashSet<Appointments>();
            Comments = new HashSet<Comments>();
            Tasks = new HashSet<Tasks>();
        }

        public int UsersId { get; set; }
        public DateTime UserCreatedTs { get; set; }
        public DateTime UserModifiedTs { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int FkContractorsId { get; set; }
        public int FkCommentsId { get; set; }

        public virtual Comments FkComments { get; set; }
        public virtual Contractors FkContractors { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
