using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUtravel.Controllers
{
    public class LineasController : ApiController
    {
        public IHttpActionResult Add(Models.Request.Lineas lineas)
        {
            using (Models.UtravelEntities8 db = new Models.UtravelEntities8())
            {
                var registro = new Models.LineasPreCompra();
                {
                    registro.IDorden = lineas.IDorden;
                    registro.IDproducto = lineas.IDproducto;
                    registro.Cantidad = lineas.Cantidad;
                    db.LineasPreCompras.Add(registro);
                    db.SaveChanges();
                }
                return Json(new { Message = "Correcto" });
            }
        }
    }
}
