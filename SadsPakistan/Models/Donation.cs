//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SadsPakistan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation
    {
        public int D_ID { get; set; }
        public Nullable<int> DT_ID { get; set; }
        public Nullable<int> C_ID { get; set; }
        public Nullable<int> Q_ID { get; set; }
        public Nullable<int> DS_ID { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Donatetype Donatetype { get; set; }
        public virtual DonationScheme DonationScheme { get; set; }
        public virtual quantityRange quantityRange { get; set; }
    }
}