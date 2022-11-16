using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCParte2.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Alejandra");
            listaUsuarios.Add("Raul");
            listaUsuarios.Add("Martin");
            listaUsuarios.Add("Ernesto");

            //ViewBag.listaUsuarios = listaUsuarios;
            //TempData["listaUsuarios"] = listaUsuarios;
            Session["listaUsuarios"] = listaUsuarios;
            //ViewData["listaUsuarios"] = listaUsuarios;

            return View(listaUsuarios);
        }

        [HttpPost]

        public ActionResult listaUsuarios(string selUsuarios)
        {
            ViewBag.Nombre = selUsuarios;
            //List<string> listUsuarios = ViewBag.listaUsuarios;
            //List<string> listUsuarios = (List<string>)TempData["listaUsuarios"];
            List<string> listUsuarios = (List<string>)Session["listaUsuarios"];
            //List<string> listUsuarios = (List<string>)ViewData["listaUsuarios"];
            return View(listUsuarios);
        }
    }
}