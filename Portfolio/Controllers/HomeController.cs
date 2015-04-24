﻿using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Home page
        /// </summary>
        /// <returns>index view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Contact page
        /// </summary>
        /// <returns>Contact view</returns>
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModels model)
        {
            return View();
        }
    }
}