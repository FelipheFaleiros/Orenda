using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orenda.Controllers
{
    public class SairController : Controller
    {
        // GET: Sair
        public  ActionResult Sair()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}