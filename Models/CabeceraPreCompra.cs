//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiUtravel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CabeceraPreCompra
    {
        public int IDorden { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaViaje { get; set; }
        public int IDUser { get; set; }
        public Nullable<int> Carros { get; set; }
        public Nullable<int> Personas { get; set; }
        public string HoraViaje { get; set; }
        public Nullable<int> CantidadPuntos { get; set; }
        public Nullable<double> MontoTotal { get; set; }
    }
}
