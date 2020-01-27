using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiUtravel.Models.Request
{
    public class UsuarioRequest
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Telefono { get; set; }        
        public string Pais { get; set; }
        public string Pass { get; set; }
    }
}