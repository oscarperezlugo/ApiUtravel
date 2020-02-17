using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUtravel.Controllers
{
    public class IdCabeceraController : ApiController
    {
        int order;
        public IHttpActionResult IDcab(Models.CabeceraPreCompra registro)
        {
            using (Models.UtravelEntities2 db = new Models.UtravelEntities2())
            {
                var myOrder = db.CabeceraPreCompras.FirstOrDefault(u => u.FechaViaje == registro.FechaViaje && u.IDUser == registro.IDUser);
                order = myOrder.IDorden;
            }
            return Json(new { idorden = order });
        }
    }
}
