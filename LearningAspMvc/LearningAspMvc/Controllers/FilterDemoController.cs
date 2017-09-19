using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAspMvc.Controllers
{
    public class FilterDemoController : Controller
    {
        // GET: FilterDemo
        [OutputCache(Duration = 10)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
        //Action Filters : OutputCache, HandleError, Authorize, 
        //Type Of Filters : Authorization Filters, Action Filters, Result Filters, Exception Filters 
    }
}