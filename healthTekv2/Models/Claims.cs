using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Claims
    {
        public Claims()
        {
            Procedures = new HashSet<Procedures>();
        }

        public int ClaimsId { get; set; }
        public DateTime ClaimCreatedTs { get; set; }
        public DateTime ClaimModifiedTs { get; set; }
        public string ClaimStatus { get; set; }
        public string CheckNumber { get; set; }
        public string DisputeReason { get; set; }
        public DateTime? PaidByInsuranceDate { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public DateTime? PaidToContractorDate { get; set; }
        public int FkInvoicesId { get; set; }

        public virtual Invoices FkInvoices { get; set; }
        public virtual ICollection<Procedures> Procedures { get; set; }
    }
}
