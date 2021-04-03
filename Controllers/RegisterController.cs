using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMgt.Models;

namespace ProjectMgt.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var cust = new Models.Customer
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Password = customer.Password
                };
                return PartialView("Register", cust);
            }

            return RedirectToAction("Kanban", "Kanban");
        }
    }
}