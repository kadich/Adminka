using Adminka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adminka.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductCreation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductCreation(ProductParameters productParameters)
        {
            return View();
        }
    }
}