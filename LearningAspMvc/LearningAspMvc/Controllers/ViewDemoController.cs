﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class ViewDemoController : Controller
    {
        // GET: ViewDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}