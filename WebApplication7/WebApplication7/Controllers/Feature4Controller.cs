using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApplication7.Models;


namespace WebApplication7.Controllers
{
    public class Feature4Controller : Controller
    {
        // GET: Feature4
        public ActionResult Index()
        {
            // GenerateCloud
            try
            {
                ViewData.Clear();
                // GenerateCloud
                ClassCloud NewCloud = new ClassCloud();
                if (!NewCloud.InitializeCloud()) { return View("~/Views/Shared/oops.cshtml"); }
                NewCloud.WeightCloud();
                ViewData.Add("DictionaryCloud",NewCloud.CloudWeighted);
                return View(NewCloud);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred: '{0}'", e);
            }
            return View("~/Views/Shared/oops.cshtml");
        }

        public ActionResult GetClassNamesOnClick()
        {
            //    string Word = Request.Params.Get("aWord");

            // string Classes = NewCloud.GetCloudClasses(entry.Key);
            //    string Classes = NewCloud.GetCloudClasses(Word);
            return View();
        }
    }
}