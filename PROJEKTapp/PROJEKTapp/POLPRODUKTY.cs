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
    
    public partial class POLPRODUKTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POLPRODUKTY()
        {
            this.PRODUKCJA_POLPRODUKTU = new HashSet<PRODUKCJA_POLPRODUKTU>();
        }
    
        public int ID_POLPRODUKTU { get; set; }
        public Nullable<int> ID_MATERIAL { get; set; }
        public Nullable<int> ID_DOKUMENTACJI { get; set; }
        public int LICZBA_SZTUK { get; set; }
    
        public virtual DOKUMENTACJA DOKUMENTACJA { get; set; }
        public virtual MATERIAL MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUKCJA_POLPRODUKTU> PRODUKCJA_POLPRODUKTU { get; set; }
    }
}
