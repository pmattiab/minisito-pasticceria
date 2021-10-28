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
    public class JsonHelper
    {
        /// <summary>
        /// Il metodo legge il contenuto del file json e lo deserealizza in un'istanza di T
        /// </summary>
        /// <typeparam name="T">tipo dell'oggetto</typeparam>
        /// <param name="_filePath">stringa del file path relativo</param>
        /// <returns>ritorna l'istanza di T</returns>
        public T ReadJson<T>(string _filePath)
        {
            // leggo il contenuto del file json
            string fileContent = ReadFile(_filePath);

            // deserializzo il contenuto del file json
            var result = JsonConvert.DeserializeObject<T>(fileContent);

            // ritorno dell'istanza di T
            return result;
        }

        /// <summary>
        /// Il metodo legge un file partendo dal path
        /// </summary>
        /// <param name="filePath">indica il path relativo</param>
        /// <returns>ritorno il contenuto del file letto</returns>
        private string ReadFile(string filePath)
        {
            // ottengo il path assoluto del file
            string fullPath = System.Web.Hosting.HostingEnvironment.MapPath(filePath);

            // ritorno il contenuto del file
            return File.ReadAllText(fullPath);
        }
    }
}