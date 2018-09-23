using Adminka.DataAccess;
using Adminka.DataAccess.Entities;
using Adminka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Adminka.Controllers
{
    public class HomeController : Controller
    {
        AdminkaContext db = new AdminkaContext();

        public ActionResult Index()
        {
            List<ProductParameters> products;
            
            using (db)
            {
                products = db.Products.Select(s => new ProductParameters
                {
                    Name = s.Name,
                    Price = s.Price,
                    InStock = s.InStock
                }).ToList();
            }

            return View(products);
        }

        [HttpGet]
        public ActionResult ProductCreation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductCreation(ProductEntity productParameters)
        {
            if (!ModelState.IsValid)
            {
                return View(productParameters);
            }

            db.Products.Add(productParameters);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}