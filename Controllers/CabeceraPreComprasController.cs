using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiUtravel.Models;

namespace ApiUtravel.Controllers
{
    public class CabeceraPreComprasController : ApiController
    {
        private UtravelEntities2 db = new UtravelEntities2();

        // GET: api/CabeceraPreCompras
        public IQueryable<CabeceraPreCompra> GetCabeceraPreCompras()
        {
            return db.CabeceraPreCompras;
        }

        // GET: api/CabeceraPreCompras/5
        [ResponseType(typeof(CabeceraPreCompra))]
        public IHttpActionResult GetCabeceraPreCompra(int id)
        {
            CabeceraPreCompra cabeceraPreCompra = db.CabeceraPreCompras.Find(id);
            if (cabeceraPreCompra == null)
            {
                return NotFound();
            }

            return Ok(cabeceraPreCompra);
        }

        // PUT: api/CabeceraPreCompras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCabeceraPreCompra(int id, CabeceraPreCompra cabeceraPreCompra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cabeceraPreCompra.IDorden)
            {
                return BadRequest();
            }

            db.Entry(cabeceraPreCompra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CabeceraPreCompraExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CabeceraPreCompras
        [ResponseType(typeof(CabeceraPreCompra))]
        public IHttpActionResult PostCabeceraPreCompra(CabeceraPreCompra cabeceraPreCompra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CabeceraPreCompras.Add(cabeceraPreCompra);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cabeceraPreCompra.IDorden }, cabeceraPreCompra);
        }

        // DELETE: api/CabeceraPreCompras/5
        [ResponseType(typeof(CabeceraPreCompra))]
        public IHttpActionResult DeleteCabeceraPreCompra(int id)
        {
            CabeceraPreCompra cabeceraPreCompra = db.CabeceraPreCompras.Find(id);
            if (cabeceraPreCompra == null)
            {
                return NotFound();
            }

            db.CabeceraPreCompras.Remove(cabeceraPreCompra);
            db.SaveChanges();

            return Ok(cabeceraPreCompra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CabeceraPreCompraExists(int id)
        {
            return db.CabeceraPreCompras.Count(e => e.IDorden == id) > 0;
        }
    }
}