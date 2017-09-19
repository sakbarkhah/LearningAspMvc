using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class SelectorDemoController : Controller
    {
        [ActionName("CurrentDate")]
        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("d");
        }
        [NonAction]
        public string GetDate()
        {
            return "Today is " + DateTime.Now.ToString("d");
        }
        public string GetDateNow()
        {
            return GetDate();
        }
        // GET: SelectorDemo
        [HttpPost]
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
        /*Why????!!!!!
            always Invoke this action even when the url is : http://localhost:13432/SelectorDemo/somayeh
            and RouteConfig is : 
                routes.MapRoute(
                "SelectorDemo",
                "SelectorDemo/{name}",
                defaults : new { controller = "SelectorDemo", action = "Search", name = UrlParameter.Optional}
            );
        */
        [HttpGet]
        public ActionResult Search()
        {
            return Content("this is the main search without input");
        }

        //ActionVerbs : HttpGet, HttpPost, HttpPut, HttpDelete, HttpOptions, HttpPatch
    }
}