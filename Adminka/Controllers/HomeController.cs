using Adminka.DataAccess;
using Adminka.DataAccess.Entities;
using Adminka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
                    Id = s.Id,
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

        [HttpPost]
        public ActionResult Delete(ProductEntity productParameters)
        {
            var b = db.Products.Find(productParameters.Id);
            if (b != null)
            {
                db.Products.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}







// навороченное удаление, потом разберусь

//public async Task<ActionResult> Delete(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }
//    var product = await db.Products.FindAsync(id);
//    if (product == null)
//    {
//        return HttpNotFound();
//    }
//    return View(product);
//}

//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public async Task<ActionResult> DeleteConfirmed(int id)
//{
//    var product = await db.Products.FindAsync(id);
//    db.Products.Remove(product);
//    await db.SaveChangesAsync();
//    return RedirectToAction("Index");
//}

//@Html.AntiForgeryToken()