using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Invoices
    {
        public Invoices()
        {
            Claims = new HashSet<Claims>();
        }

        public int InvoicesId { get; set; }
        public DateTime InvoiceCreatedTs { get; set; }
        public DateTime InvoiceModifiedTs { get; set; }
        public string InvoiceStatus { get; set; }
        public byte[] Invoice { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public int FkFacilitiesId { get; set; }

        public virtual Facilities FkFacilities { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
    }
}
