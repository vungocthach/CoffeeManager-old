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
    using System.Collections.ObjectModel;
    
    public partial class TABLE : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE()
        {
            this.BILLs = new  ObservableCollection<BILL>();
        }
    
        public long ID { get; set; }
        public int Floor { get; set; }
        public Nullable<long> ID_Status { get; set; }
        public Nullable<int> DELETED { get; set; }
        public int Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<BILL> BILLs { get; set; }
        public virtual STATUS_TABLE STATUS_TABLE { get; set; }
    }
}
