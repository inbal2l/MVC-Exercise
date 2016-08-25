using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Feature1Controller : Controller
    {
        // GET: Feature1
        public ActionResult Index()
        {
            try
            {
                ViewData.Clear();
                ClassName NewClass = new ClassName();
                if(!NewClass.GetTextFromPage()) { return View("~/Views/Shared/oops.cshtml");  }
                ViewData["ResponseString"] = NewClass.ResponseString;
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred: '{0}'", e);
            }
            return View("~/Views/Shared/oops.cshtml");
        }
    }
}