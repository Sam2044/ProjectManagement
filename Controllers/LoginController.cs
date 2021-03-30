using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMgt.Models;

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
        public ActionResult Check(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var cust = new Models.Customer
                {
                    Email = customer.Email,
                    Password = customer.Password
                };
                return PartialView("LoginPretty",cust);
            }

            return RedirectToAction("Kanban", "Kanban");
        }
    }
}