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
    
    public partial class PRODUCT : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.DETAILBILLs = new  ObservableCollection<DETAILBILL>();
        }
    
        public long ID { get; set; }
        public string NAME { get; set; }
        public string DETAIL { get; set; }
        public byte[] IMAGE { get; set; }
        public Nullable<long> PRICE { get; set; }
        public string TYPE { get; set; }
        public Nullable<int> DELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<DETAILBILL> DETAILBILLs { get; set; }
    }
}
