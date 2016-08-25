using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Feature2Controller : Controller
    {
        // GET: Feature2
        public ActionResult Index()
        {
            try
            {
                ViewData.Clear();
                ClassName NewClass = new ClassName();
                if (!NewClass.GetTextFromPage()) { return View("~/Views/Shared/oops.cshtml"); }
                ViewData["Name1"] = @NewClass.ResponseString;
                if(!NewClass.GetTextFromPage()) { return View("~/Views/Shared/oops.cshtml"); }
                ViewData["Name2"] = @NewClass.ResponseString;
                if(!NewClass.GetTextFromPage()) { return View("~/Views/Shared/oops.cshtml"); }
                ViewData["Name3"] = @NewClass.ResponseString;
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine("A class name could be retrieved. The error: '{0}'", e);
            }
            return View("~/Views/Shared/oops.cshtml");
        }
    }
}