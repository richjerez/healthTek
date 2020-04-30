using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Papers
    {
        public int PapersId { get; set; }
        public DateTime PaperCreatedTs { get; set; }
        public DateTime PaperModifiedTs { get; set; }
        public string PaperTitle { get; set; }
        public string PaperStatus { get; set; }
        public DateTime? PaperEffDate { get; set; }
        public DateTime? PaperExpDate { get; set; }
        public string PaperDescription { get; set; }
        public string PaperIdentifier { get; set; }
        public ulong? RequiredItem { get; set; }
        public short? ExpWarningNumDays { get; set; }
        public byte[] DigitalPaper { get; set; }
        public ulong? IsSorted { get; set; }
        public string UploadDate { get; set; }
        public int FkClientsId { get; set; }
        public int FkContractorsId { get; set; }

        public virtual Clients FkClients { get; set; }
        public virtual Contractors FkContractors { get; set; }
    }
}
