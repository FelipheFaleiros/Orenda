using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orenda.Models;

namespace Orenda.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        [HttpGet]
        public ActionResult Cadastro()
        {
            if (Session["Autorizado"] != null)
            {
                return View();
            }
            else
            {
                Response.Redirect("/Login/Index");
                return null;
            }   
        }

        [HttpPost]
        public ActionResult Cadastrar(Clientes cadastrar)
        {
            cadastrar.Cadastrar();
            return Content("TOP");
        }

        public ActionResult Relatorio()
        {
            return View()
        }
    }
}