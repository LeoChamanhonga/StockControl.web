using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockControl.web.Controllers
{
    public class RegistroController : Controller
    {
        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Armazem()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }

        [Authorize]
        public ActionResult Provincia()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cidades()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUtilizador()
        {
            return View();
        }

        [Authorize]
        public ActionResult Utilizador()
        {
            return View();
        }








    }
}