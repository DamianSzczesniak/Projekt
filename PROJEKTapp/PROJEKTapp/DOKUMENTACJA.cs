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
    
    public partial class DOKUMENTACJA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKUMENTACJA()
        {
            this.POLPRODUKTY = new HashSet<POLPRODUKTY>();
        }
    
        public int ID_DOKUMENTACJI { get; set; }
        public string NR_RYSUNKU { get; set; }
        public System.DateTime DATA_WPROWADZENIA { get; set; }
        public Nullable<int> ID_PRACOWNIK { get; set; }
        public Nullable<int> ID_PROJEKTU { get; set; }
    
        public virtual PRACOWNICY PRACOWNICY { get; set; }
        public virtual PROJEKT PROJEKT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POLPRODUKTY> POLPRODUKTY { get; set; }
    }
}
