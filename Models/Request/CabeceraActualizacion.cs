using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiUtravel.Models.Request
{
    public class CabeceraActualizacion
    {
        public int IDorden { get; set; }
        public Nullable<int> CantidadPuntos { get; set; }
        public Nullable<double> MontoTotal { get; set; }
    }
}