using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiUtravel.Models.Request
{
    public class Lineas
    {
        public Nullable<int> IDorden { get; set; }
        public int IDproducto { get; set; }
        public Nullable<int> Cantidad { get; set; }
    }
}