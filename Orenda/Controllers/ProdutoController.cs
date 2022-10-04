using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orenda.Controllers
{
    public class ProdutoController : Controller
    {
     
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

        //[HttpPost]
        //public ActionResult Cadastrar(Produtos cadastrar)
        //{
        //    cadastrar.Cadastrar();
        //    return Content("TOP");
        //}

        public ActionResult Relatorio()
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
    }
}