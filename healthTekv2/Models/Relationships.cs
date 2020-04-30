using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Relationships
    {
        public int RelationshipsId { get; set; }
        public DateTime RelationshipCreatedTs { get; set; }
        public DateTime RelationshipModifiedTs { get; set; }
        public string RelationshipType { get; set; }
        public int FkClientsId { get; set; }
        public int FkPersonsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Persons FkPersons { get; set; }
    }
}
