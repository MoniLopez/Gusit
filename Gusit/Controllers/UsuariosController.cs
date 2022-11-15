using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gusit.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult AltaUsuarios()
        {
            return View();
        }

        public ActionResult ModificarUsuarios()
        {
            return View();
        }

        public ActionResult VincularUsuario()
        {
            return View();
        }
    }
}