//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zerohungerv2.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class COLLECT_RQST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COLLECT_RQST()
        {
            this.FOOD_ITEM = new HashSet<FOOD_ITEM>();
        }
    
        public int C_ID { get; set; }
        public int R_ID { get; set; }
        public int E_ID { get; set; }
        public int MAX_PRESERVE_TIME { get; set; }
        public string STATUS { get; set; }
        public string FOOD_NAME { get; set; }
    
        public virtual NGO_EMP NGO_EMP { get; set; }
        public virtual RESTAURANT RESTAURANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOD_ITEM> FOOD_ITEM { get; set; }
    }
}
