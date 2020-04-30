using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Codes
    {
        public int CodesId { get; set; }
        public DateTime CodeCreatedTs { get; set; }
        public DateTime CodeModifiedTs { get; set; }
        public string CodeType { get; set; }
        public string CodeTitle { get; set; }
        public DateTime? CodeEffDate { get; set; }
        public DateTime? CodeExpDate { get; set; }
        public string CodeDescription { get; set; }
        public string CodeRateType { get; set; }
        public decimal? CodeRate { get; set; }
        public int FkProceduresId { get; set; }
        public int FkClientsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Procedures FkProcedures { get; set; }
    }
}
