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
    
    public partial class STAWKA_PRACOWNICY
    {
        public int ID_PRACOWNIK { get; set; }
        public int ID_STAWKA { get; set; }
        public System.DateTime DATA_START { get; set; }
        public Nullable<System.DateTime> DATA_KONIEC { get; set; }
    
        public virtual STAWKA STAWKA { get; set; }
        public virtual PRACOWNICY PRACOWNICY { get; set; }
    }
}
