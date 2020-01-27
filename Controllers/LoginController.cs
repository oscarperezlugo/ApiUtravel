using ApiUtravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiUtravel.Controllers
{
    public class LoginController : ApiController
    {
        string TokenRes;
        int ID;
        public IHttpActionResult VerifyPassword(Models.Request.Login user)
        {
            Models.UtravelEntities1 db = new Models.UtravelEntities1();
            {
                var myUser = db.Usuarios.FirstOrDefault(u => u.User == user.User && u.Pass == user.Pass);                                            
                if (myUser != null)    
                {
                    string token = "11a1ac2d7df61d02578f299669e09815";
                    ID = myUser.IDUser;
                    TokenRes = token;
                    
                }
                else    
                {
                    string token = "0";
                    TokenRes = token;
                    ID = 0;
                }
                return Json(new { Token = TokenRes.ToString(), id = ID });
            }            
        }
        

    }

}
