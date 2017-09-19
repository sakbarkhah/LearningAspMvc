using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class RedirectDemoController : Controller
    {
        // GET: RedirectDemo
        public string Index()
        {
            return @"<center><h4>This Is The Redirect To Action In Another Controller, Look At The Address Bar!</h4></center>";
        }
    }
}