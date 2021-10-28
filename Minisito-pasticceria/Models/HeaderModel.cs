using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minisito_pasticceria.Models
{
    public class HeaderModel
    {
        public string Title { get;  set; }
        public string Subtitle{ get;  set; }

        public string getTitle()
        {
            return this.Title;
        }

        public string getSubtitle()
        {
            return this.Subtitle;
        }

    }
}