using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockControl.web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public ActionResult EntradaStock()
        {
            return View();
        }

        [Authorize]
        public ActionResult SaidaStock()
        {
            return View();
        }

        [Authorize]
        public ActionResult LancPerdas()
        {
            return View();
        }

        [Authorize]
        public ActionResult ContagemStock()
        {
            return View();
        }

    }
}