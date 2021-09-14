using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorDirectory.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Authors()
        {
            return View();
        }

        public ActionResult FavouriteAuthors()
        {
            return View();
        }
    }
}