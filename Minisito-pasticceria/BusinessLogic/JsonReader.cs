using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Minisito_pasticceria.Models;
using Minisito_pasticceria.BusinessLogic;

namespace Minisito_pasticceria.BusinessLogic
{
    public class JsonReader
    {
        private JsonHelper service;

        public JsonReader()
        {
            this.service = new JsonHelper();
        }

        //public PageElement ReadJsonPage(string jsonFilePath)
        //{
        //    //string jsonCont = ReadFile(jsonFilePath);

        //    //PageElement deserializedObj = JsonConvert.DeserializeObject<PageElement>(jsonCont);

        //    //return deserializedObj;

        //    return this.service.ReadJson<PageElement>(jsonFilePath);

        //}

        //public List<MainMenuItem> ReadJsonMenu(string jsonFilePath)
        //{
        //    //string jsonCont = ReadFile(jsonFilePath);

        //    //var deserializedObj = JsonConvert.DeserializeObject<List<MainMenuItem>>(jsonCont);

        //    //return deserializedObj;

        //    return this.service.ReadJson<List<MainMenuItem>>(jsonFilePath);
        //}
    }
}