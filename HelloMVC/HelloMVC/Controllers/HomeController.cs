﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if(Session["user"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

            var stagees = HelloModel.GetStagees();
            ViewBag.SubanCreatedThis = "The Team";

            return View(stagees);
        }
    }
}