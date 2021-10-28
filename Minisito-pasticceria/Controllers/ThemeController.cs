using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minisito_pasticceria.Models;

namespace Minisito_pasticceria.Controllers
{
    public class ThemeController : Controller
    {

        // dice al compilatore che non può chiamare questo
        // metodo direttamente ma solo come metodo parziale
        [ChildActionOnly]
        public ActionResult MainMenu()
        {   
            var linksList = new MainMenuModel();

            return PartialView(linksList);
        }

        [ChildActionOnly]
        public ActionResult PageElement()
        {
            var elements = new PageElementModel();

            return PartialView(elements);
        }
    }
}