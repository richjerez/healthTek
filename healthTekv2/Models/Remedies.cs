using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Remedies
    {
        public Remedies()
        {
            Programs = new HashSet<Programs>();
        }

        public int RemediesId { get; set; }
        public DateTime RemedyCreatedTs { get; set; }
        public DateTime RemedyModifiedTs { get; set; }
        public string RemedyName { get; set; }
        public string RemedyDescription { get; set; }
        public int FkClientsId { get; set; }
        public int FkProgramsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Programs FkPrograms { get; set; }
        public virtual ICollection<Programs> Programs { get; set; }
    }
}
