using Flagsmith;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace flagsmith_error_repro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var flagsmithClient = new FlagsmithClient("ser...", enableClientSideEvaluation: true);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}