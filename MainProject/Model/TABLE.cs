//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE()
        {
            this.BILLs = new HashSet<BILL>();
        }
    
        public long ID { get; set; }
        public Nullable<int> FLOORS { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> NUMBER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }
    }
}
