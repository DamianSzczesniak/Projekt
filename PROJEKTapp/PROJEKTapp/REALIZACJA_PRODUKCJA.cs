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
    
    public partial class REALIZACJA_PRODUKCJA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REALIZACJA_PRODUKCJA()
        {
            this.PRACOWNICY = new HashSet<PRACOWNICY>();
            this.MASZYNY = new HashSet<MASZYNY>();
            this.MATERIAL = new HashSet<MATERIAL>();
            this.NARZEDZIA = new HashSet<NARZEDZIA>();
        }
    
        public int ID_REALIZACJA_PRODUKCJA { get; set; }
        public int ID_ZLECENIA { get; set; }
        public System.DateTime DATA_DZIEN { get; set; }
        public int LICZBA_SZTUK { get; set; }
    
        public virtual ZLECENIA ZLECENIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRACOWNICY> PRACOWNICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MASZYNY> MASZYNY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIAL> MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NARZEDZIA> NARZEDZIA { get; set; }
    }
}
