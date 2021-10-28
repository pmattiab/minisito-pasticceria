using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Minisito_pasticceria.BusinessLogic;

namespace Minisito_pasticceria.Models
{
    public class PageElementModel
    {
        public PageElementModel()
        {
            //string jsonPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Data/pageElements.json");
            //string jsonCont = File.ReadAllText(jsonPath);
            //this.Element = JsonConvert.DeserializeObject<PageElement>(jsonCont);

            string filePath = "~/Data/pageElements.json";

            var service = new JsonHelper();

            this.Element = service.ReadJson<PageElement>(filePath);
        }

        public PageElement Element { get; set; }

    }

    public class PageElement
    {
        public string imgPath { get; set; }
        public string title { get; set; }
        public string subTitle { get; set; }
        public string paragraph { get; set; }
    }
}