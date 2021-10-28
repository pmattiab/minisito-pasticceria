using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minisito_pasticceria.BusinessLogic;
using Minisito_pasticceria.Models;

namespace Minisito_pasticceria.Controllers
{
    public class PageController : Controller
    {

        private const string jsonRelativePath = "~/Data/posts.json";
        // GET: Page
        public ActionResult List()
        {
            List<PostModel> postListFromFile = new PostService().GetPostListFromJsonWithPath(jsonRelativePath);

            ViewBag.postList = postListFromFile;

            return View();
        }

        public ActionResult Detail(int? id)
        {
            if(!id.HasValue)
            {
                return RedirectToAction("List");
            }
            
            List<PostModel> postListFromFile = new PostService().GetPostListFromJsonWithPath(jsonRelativePath);

            var post = postListFromFile.Find(singlepost => singlepost.id == id);

            //var post = postListFromFile.Where(w => w.id == id).FirstOrDefault();

            //var post = postListFromFile.FirstOrDefault(x => x.id == id);

            //PostModel post = new PostModel();

            //post.id = id.Value;

            return View(post);
        }
    }
}