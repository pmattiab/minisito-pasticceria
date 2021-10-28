using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minisito_pasticceria.Models;

namespace Minisito_pasticceria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
             
            HeaderModel headerT = new HeaderModel();

            headerT.Title = "A Free Bootstrap Business Theme";
            headerT.Subtitle = "Business Casual";

            ViewBag.HeaderMod = headerT;

            return View();
        }

        public ActionResult About()
        {
            HeaderModel headerT = new HeaderModel();

            headerT.Subtitle = "Business Casual";

            ViewBag.HeaderMod = headerT;

            return View();
        }
        
        public ActionResult Products()
        {
            HeaderModel headerT = new HeaderModel();

            headerT.Subtitle = "Business Casual";

            ViewBag.HeaderMod = headerT;

            return View();
        }

        public ActionResult Store()
        {
            HeaderModel headerT = new HeaderModel();

            headerT.Subtitle = "Business Casual";

            ViewBag.HeaderMod = headerT;

            return View();
        }

    }
}