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
    
    public partial class SZKOLENIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SZKOLENIA()
        {
            this.PRACOWNICY = new HashSet<PRACOWNICY>();
        }
    
        public int ID_SZKOLENIA { get; set; }
        public string NAZWA_SZKOLENIA { get; set; }
        public string OPIS_SZKOLENIA { get; set; }
        public System.DateTime DATA_START { get; set; }
        public System.DateTime DATA_KONIEC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRACOWNICY> PRACOWNICY { get; set; }
    }
}