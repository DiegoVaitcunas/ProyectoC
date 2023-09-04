using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioP2UI.Controllers
{
    public class LoginController : Controller
    {
        private Sistema sistema = Sistema.Instancia;

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UsuarioLogueado");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginView(Usuario usuario)
        {
            try
            {
                sistema.Login(usuario);
            }
            catch (Exception e)
            {
                ViewBag.NombreError = e.Message;
                return View();
            }
                HttpContext.Session.SetString("UsuarioLogueado", usuario.Email);
                return RedirectToAction("Index", "Home");
        }
    }
}
