using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orenda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult About()
        {
            if (Session["Autorizado"] != null)
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            else
            {
                //Response.Redirect("/Login/Index");
                //return null;
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Contact()
        {
            if (Session["Autorizado"] != null)
            {
                ViewBag.Message = "Your contact page.";

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