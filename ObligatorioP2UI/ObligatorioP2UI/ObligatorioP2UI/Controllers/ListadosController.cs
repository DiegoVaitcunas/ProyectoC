using Microsoft.AspNetCore.Mvc;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Obligatorio2UI.Controllers
{
    public class ListadosController : Controller
    {
        Sistema sistema = Sistema.Instancia;

        #region Listado para usuarios no logueados
        public IActionResult ListarSeleccionesNoLog()
        {
            List<Seleccion> selecciones = sistema.VisualizarSelecciones();
            return View(selecciones);
        }
        #endregion
        #region Listado para periodistas
        public IActionResult ListarPartidosCerrados()
        {
            List<Partido> Partidos = sistema.ListarPartidosFinalizados();
            return View(Partidos);
        }
        public IActionResult ListarResenias()
        {
            string userLog = HttpContext.Session.GetString("UsuarioLogueado");
            List<Resenia> Resenias = sistema.ListarReseniasDePeriodista(userLog);
            return View(Resenias);
        }
        #endregion
    }
}
