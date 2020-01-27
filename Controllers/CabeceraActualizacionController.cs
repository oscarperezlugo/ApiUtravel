using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUtravel.Controllers
{
    public class CabeceraActualizacionController : ApiController
    {
        public IHttpActionResult Add(Models.Request.CabeceraActualizacion cabecera)
        {
            using (Models.UtravelEntities2 db = new Models.UtravelEntities2())
            {
                var registro = new Models.CabeceraPreCompra();
                {
                    var myOrder = db.CabeceraPreCompras.FirstOrDefault(u => u.IDorden == cabecera.IDorden);
                    myOrder.MontoTotal = cabecera.MontoTotal;
                    myOrder.CantidadPuntos = cabecera.CantidadPuntos;
                    db.SaveChanges();
                }
                return Json(new { message = "actualiado" });
            }
        }
    }
}
