using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class HomeController : Controller
    {
        //First Action
        public string Welcome()
        {
            return "Hi! Welcome to Asp.Net Tutorial";
        }
        //RedirectToAction
        public string RedirectTest()
        {
            return "<center><h4>This Is The Redirect To Action In Same Controller, Look At The Address Bar</h4></center>";
        }
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Index", "RedirectDemo");
        }
        public ActionResult RedirectAction()
        {
            return RedirectToAction("RedirectTest");
        }
    }
}