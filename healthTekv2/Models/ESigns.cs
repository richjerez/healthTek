using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class ESigns
    {
        public int ESignsId { get; set; }
        public DateTime ESignsCreatedTs { get; set; }
        public DateTime ESignsModifiedTs { get; set; }
        public ulong? ESignConsent { get; set; }
        public string ESignIp { get; set; }
        public byte[] ESignature { get; set; }
        public int FkPersonsId { get; set; }

        public virtual Persons FkPersons { get; set; }
    }
}
