using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUtravel.Controllers
{
    public class UsuarioCreacionController : ApiController
    {
        public IHttpActionResult Add(Models.Request.UsuarioRequest usuario)
        {
            using(Models.UtravelEntities1 db = new Models.UtravelEntities1())
            {
                var registro = new Models.Usuario();
                {
                    registro.Nombre = usuario.Nombre.ToString();
                    registro.Email = usuario.Email.ToString();
                    registro.Pais = usuario.Pais.ToString();
                    registro.Pass = usuario.Pass.ToString();
                    registro.User = usuario.User.ToString();
                    registro.Telefono = usuario.Telefono.ToString();
                    registro.FechaRegistro = DateTime.Now;
                    db.Usuarios.Add(registro);
                    db.SaveChanges();
                }
                return Json(new { message = registro.Nombre.ToString() });
            }
        }
    }
}
