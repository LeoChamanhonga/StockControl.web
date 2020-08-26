using StockControl.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StockControl.web.Controllers
{
    public class ContaController : Controller
    {
        
        
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
           if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = (login.Utilizador == "leonel" && login.Senha == "123");

            if(achou)
            {
                FormsAuthentication.SetAuthCookie(login.Utilizador, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }

            }
            else
            {
                ModelState.AddModelError("", "Login Invalido.");
            }
            return View(login);

        }
    }
}