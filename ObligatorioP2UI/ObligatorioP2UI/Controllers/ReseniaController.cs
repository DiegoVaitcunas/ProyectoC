using Microsoft.AspNetCore.Mvc;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ObligatorioP2UI.Controllers
{
    public class ReseniaController : Controller
    {
        Sistema sistema = Sistema.Instancia;
        public IActionResult ReseniaView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReseniaView(Resenia r)
        {
            string PeriodistaLog = HttpContext.Session.GetString("UsuarioLogueado");
                //Partido partidoResenia = sistema.SetPartido(r.unPartido.Id);
            try
            {
                sistema.CrearResenia(r,PeriodistaLog);
                return RedirectToAction("ListarResenias","Listados");
            }
            catch(Exception e)
            {
                ViewBag.NombreError = e.Message;
                return View();
            }
        }
    }
}
