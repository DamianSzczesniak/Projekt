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
    
    public partial class PRACOWNICY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRACOWNICY()
        {
            this.DOKUMENTACJA = new HashSet<DOKUMENTACJA>();
            this.FAKTURY = new HashSet<FAKTURY>();
            this.STAWKA_PRACOWNICY = new HashSet<STAWKA_PRACOWNICY>();
            this.WOLNE_PRACOWNICY = new HashSet<WOLNE_PRACOWNICY>();
            this.ADRESY_PRACOWNICY = new HashSet<ADRESY_PRACOWNICY>();
            this.SZKOLENIA = new HashSet<SZKOLENIA>();
            this.REALIZACJA_PRODUKCJA = new HashSet<REALIZACJA_PRODUKCJA>();
            this.STANOWISKO_PRACOWNICY = new HashSet<STANOWISKO_PRACOWNICY>();
            this.UZYTKOWNICY = new HashSet<UZYTKOWNICY>();
        }
    
        public int ID_PRACOWNIK { get; set; }
        public string NAZWISKO { get; set; }
        public string IMIE { get; set; }
        public string TELEFON { get; set; }
        public string PESEL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOKUMENTACJA> DOKUMENTACJA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAKTURY> FAKTURY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAWKA_PRACOWNICY> STAWKA_PRACOWNICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOLNE_PRACOWNICY> WOLNE_PRACOWNICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADRESY_PRACOWNICY> ADRESY_PRACOWNICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SZKOLENIA> SZKOLENIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REALIZACJA_PRODUKCJA> REALIZACJA_PRODUKCJA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STANOWISKO_PRACOWNICY> STANOWISKO_PRACOWNICY { get; set; }
        public virtual ICollection<UZYTKOWNICY> UZYTKOWNICY { get; set; }
    }
}
