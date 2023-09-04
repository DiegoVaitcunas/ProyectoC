using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioP2UI.Controllers
{
    public class RegistroController : Controller
    {
        private Sistema sistema = Sistema.Instancia;

        public IActionResult RegisterView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterView(Usuario u)
        {
            sistema.Registrar(u);
            return RedirectToAction("LoginView", "Login");
        }
    }
}
