//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJEKTapp
{
    using System;
    using System.Collections.Generic;
    
    public partial class WOLNE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WOLNE()
        {
            this.WOLNE_PRACOWNICY = new HashSet<WOLNE_PRACOWNICY>();
        }
    
        public int ID_WOLNE { get; set; }
        public string SYMBOL { get; set; }
        public string NAZWA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOLNE_PRACOWNICY> WOLNE_PRACOWNICY { get; set; }
    }
}