using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minisito_pasticceria.Models
{
    public class PostModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}