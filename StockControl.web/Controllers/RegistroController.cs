using StockControl.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockControl.web.Controllers
{
    public class RegistroController : Controller
    {
        private static List<GrupoProdutoModel> _listaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() { Id=1, Nome="Livros", Ativo=true},
            new GrupoProdutoModel() { Id=2, Nome="Canetas", Ativo=true},
            new GrupoProdutoModel() { Id=3, Nome="PC", Ativo=false}

        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
           
            return View(_listaGrupoProduto);
        }

        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto(int id)
        {
            return Json(_listaGrupoProduto.Find(x => x.Id == id));
        }

        [HttpPost]
        [Authorize]
        public ActionResult ExcluirGrupoProduto(int id)
        {
            var ret = false;

            var registoDB = _listaGrupoProduto.Find(x => x.Id == id);
            if (registoDB != null)
            {
                _listaGrupoProduto.Remove(registoDB);
                ret = true;
            }
            return Json(ret);
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