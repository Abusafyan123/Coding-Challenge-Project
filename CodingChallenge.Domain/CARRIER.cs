//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodingChallenge.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARRIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARRIER()
        {
            this.SHIPMENTs = new HashSet<SHIPMENT>();
        }
    
        public int carrier_id { get; set; }
        public string carrier_name { get; set; }
        public string carrier_mode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENT> SHIPMENTs { get; set; }
    }
}