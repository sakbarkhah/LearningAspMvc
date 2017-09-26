using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class PractiseRedirectController : Controller
    {
        // GET: PractiseRedirect
        public ActionResult Index()
        {
            if(Request.Cookies["LinkCookie"] == null)
                Response.SetCookie(CreateLinkCookie());
            return View();
        }
        public ActionResult RedirectTest()
        {
            if (Request.Cookies["LinkCookie"].Value == "0")
                {
                    Response.Cookies["LinkCookie"].Value = "1";
                    return RedirectToAction("FakePage");
                }
                else if (Request.Cookies["LinkCookie"].Value == "1")
                {
                    Response.Cookies["LinkCookie"].Value = "0";
                    return RedirectToAction("MainPage");
                }
           else
                return View();               
        }
        private HttpCookie CreateLinkCookie()
        {
            HttpCookie LinkCookie = new HttpCookie("LinkCookie", "0");
            LinkCookie.Expires = DateTime.Now.AddMinutes(1);
            return LinkCookie;
        }
        public string FakePage()
        {
            return "<center>This Is A Fake Page :D</center>";
        }
        public string MainPage()
        {
            return "<center>WOW! This is the main page</center>";
        }
    }
}