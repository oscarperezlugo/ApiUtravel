using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiUtravel.Models.Request
{
    public class CreacionCabecera
    {
        public System.DateTime FechaViaje { get; set; }
        public int IDUser { get; set; }
        public Nullable<int> Carros { get; set; }
        public Nullable<int> Personas { get; set; }
        public string HoraViaje { get; set; }
    }
}