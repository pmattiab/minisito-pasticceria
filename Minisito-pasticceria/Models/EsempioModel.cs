using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;

namespace Minisito_pasticceria.Models
{
    public class EsempioModel


    {
        // public MainMenuItem CurrentItem { get; set; }

        public List<MainMenuItem> Items { get; set; }

        public EsempioModel()
        {
            //   this.Titolo = "titolo di default";

            string jsonString = @"
                                {
                                    ""JsonValues"": {
                                        ""id"": ""MyID"",
                                        ""values"": {
                                            ""value1"": {
                                                ""id"": ""100"",
                                                ""diaplayName"": ""MyValue1""
                                            },
                                            ""value2"": {
                                                ""id"": ""200"",
                                                ""diaplayName"": ""MyValue2""
                                            }
                                        }
                                    }
                                }";

            jsonString = @"
                                {
                                    ""label"": ""mia label"",
                                    ""url"": ""mio url""
                                }";


            string jsonStringList = @"[
                                {
                                    ""label"": ""mia label"",
                                    ""url"": ""mio url""
                                },
{
                                    ""label"": ""mia label"",
                                    ""url"": ""mio url""
                                }
                                    ]";


            var res = JsonConvert.DeserializeObject<Wrapper>(jsonString);

            var res2 = JsonConvert.DeserializeObject<Wrapper2>(jsonString);

            var res3 = JsonConvert.DeserializeObject<List<Wrapper3>>(jsonStringList);

            // string filePath = HttpContext.Current.Server.MapPath("~/Data/menu.json");
            //
            // alternativa a HttpContext.Current.Server.MapPath
            string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Data/menu.json");

            string jsonContent = File.ReadAllText(filePath);

            this.Items = new List<MainMenuItem>();
        }
    }

    class Wrapper3
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }



    class Wrapper2
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }








    class Wrapper
    {
        [JsonProperty("JsonValues")]
        public ValueSet ValueSet { get; set; }
    }

    class ValueSet
    {
        [JsonProperty("label")]

        public string Label { get; set; }

        [JsonProperty("values")]

        public Dictionary<string, Value> Values { get; set; }
    }

    class Value
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("diaplayName")]

        public string DisplayName { get; set; }
    }




    public class MainMenuItem
    {
        public string Label { get; set; }
        public string Url { get; set; }
    }
}