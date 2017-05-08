using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampoElectrico.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Decimal k, Decimal q, Decimal r, Decimal u)
        {
            ViewBag.Resultado = k*(q/(r*r))*u;
            return View();
        }
    }
}