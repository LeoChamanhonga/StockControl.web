using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockControl.web.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult EstadoStock()
        {
            return View();
        }

        [Authorize]
        public ActionResult Reabastecer()
        {
            return View();
        }
    }
}