using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMgt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPretty()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Check()
        {
            return RedirectToAction("Kanban", "Kanban");
        }
    }
}