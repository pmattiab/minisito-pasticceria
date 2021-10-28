using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minisito_pasticceria.Models;
using System.IO;

namespace Minisito_pasticceria.BusinessLogic
{
    public class PostService
    {
        public List<PostModel> GetPostListFromJsonWithPath(string _jsonRelativePath)
        {
            string jsonContent = this.ReadJsonFromRelPath(_jsonRelativePath);

            var result = new JsonDeserializer().DeserializeJson<List<PostModel>>(jsonContent);

            if (result == null)
            {
                result = new List<PostModel>();
            }

            return result;
        }

        private string ReadJsonFromRelPath(string relFilePath)
        {
            // ottengo il path assoluto del file
            string absFilePath = System.Web.Hosting.HostingEnvironment.MapPath(relFilePath);

            // ritorno il contenuto del file
            return File.ReadAllText(absFilePath);
        }
    }
}