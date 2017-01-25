using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if("sazfc".Equals(name) && "sazfc".Equals(password))
            {
                Session["user"] = new User() { Login = name, Name = "Saz" };
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction( "Index", "Home");
        }
    }
}