using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUtravel.Controllers
{
    public class CabeceraCreacionController : ApiController
    {
        public IHttpActionResult Add(Models.Request.CreacionCabecera cabecera)
        {
            using (Models.UtravelEntities2 db = new Models.UtravelEntities2())
            {
                var registro = new Models.CabeceraPreCompra();
                {
                    registro.FechaCreacion = DateTime.Now;
                    registro.FechaViaje = cabecera.FechaViaje;
                    registro.IDUser = cabecera.IDUser;
                    registro.Carros = cabecera.Carros;
                    registro.Personas = cabecera.Personas;
                    registro.HoraViaje = cabecera.HoraViaje;
                    db.CabeceraPreCompras.Add(registro);
                    db.SaveChanges();
                }
                return Json(new { message = "creado" });
            }
        }
    }
}
