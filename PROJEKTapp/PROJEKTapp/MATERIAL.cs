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
    
    public partial class MATERIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATERIAL()
        {
            this.PARAMETRY_MATERIALU = new HashSet<PARAMETRY_MATERIALU>();
            this.POLPRODUKTY = new HashSet<POLPRODUKTY>();
            this.REALIZACJA_PRODUKCJA = new HashSet<REALIZACJA_PRODUKCJA>();
        }
    
        public int ID_MATERIALU { get; set; }
        public string NAZWA { get; set; }
        public string PELNA_NAZWA_MATERIALU { get; set; }
        public string OZNACZENIE_SUROWCA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARAMETRY_MATERIALU> PARAMETRY_MATERIALU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POLPRODUKTY> POLPRODUKTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REALIZACJA_PRODUKCJA> REALIZACJA_PRODUKCJA { get; set; }
    }
}