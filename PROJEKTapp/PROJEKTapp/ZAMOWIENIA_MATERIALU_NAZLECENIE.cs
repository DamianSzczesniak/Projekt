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
    
    public partial class ZAMOWIENIA_MATERIALU_NAZLECENIE
    {
        public int ID_ZLECENIA { get; set; }
        public int ID_PRODUKTU { get; set; }
        public Nullable<int> ILOSC { get; set; }
        public int ID_POLPRODUKTU { get; set; }
        public int ID_MATERIAL { get; set; }
        public string NAZWA { get; set; }
        public int LICZBA_SZTUK { get; set; }
        public Nullable<int> SUMA_p { get; set; }
    }
}