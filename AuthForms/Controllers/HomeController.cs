﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthForms.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string result = "Вы не авторизованы";
            if(User.Identity.IsAuthenticated)
            {
                result = "Ващ логин: " + User.Identity.Name;
            }
            return result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}