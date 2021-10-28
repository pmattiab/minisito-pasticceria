using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Minisito_pasticceria.BusinessLogic;

namespace Minisito_pasticceria.Models
{
    public class MainMenuModel
    {
        public MainMenuModel()
        {

            // string filePath = HttpContext.Current.Server.MapPath("~/Data/menu.json");
            //
            // alternativa a HttpContext.Current.Server.MapPath
            //string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Data/menu.json");

            string filePath = "~/Data/menu.json";

            var service = new JsonHelper();

            this.Items = service.ReadJson<List<MainMenuItem>>(filePath);

            if(this.Items == null)
            {
                this.Items = new List<MainMenuItem>();
            }
        }

        public List<MainMenuItem> Items { get; set; }
    }

    public class MainMenuItem
    {
        public string Label { get; set; }
        public string Url { get; set; }
    }

}