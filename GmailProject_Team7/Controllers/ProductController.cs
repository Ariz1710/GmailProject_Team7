using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GmailProject_Team7.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ShowAllProduct()
        {
            return View();
        }
    }
}