using System;
using System.Collections.Generic;

namespace healthTekv2.Models
{
    public partial class Providers
    {
        public Providers()
        {
            Supervisions = new HashSet<Supervisions>();
        }

        public int ProvidersId { get; set; }
        public DateTime ProviderCreatedTs { get; set; }
        public DateTime ProviderModifiedTs { get; set; }
        public string ProviderCompany { get; set; }
        public string ProviderNumber { get; set; }
        public string ProviderType { get; set; }
        public string ProviderUrl { get; set; }
        public string ProviderEin { get; set; }
        public string ProviderIdentifier { get; set; }
        public int FkContractorsId { get; set; }

        public virtual Contractors FkContractors { get; set; }
        public virtual ICollection<Supervisions> Supervisions { get; set; }
    }
}
