using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC04.Models;
using System.IO;
using System.Data.Entity.Infrastructure;

namespace MVC04.Controllers
{
    public class NewProductController : Controller
    {
        [HttpGet]
        public ActionResult NewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(tblProduct tblProduct)
        {
            string filename = Path.GetFileNameWithoutExtension(tblProduct.ImageFile.FileName);
            string extension = Path.GetExtension(tblProduct.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssff") + extension;
            tblProduct.ImageURL = "~/img/" + filename;
            filename = Path.Combine(Server.MapPath("~/img/"), filename);
            tblProduct.ImageFile.SaveAs(filename);
            using(DB_EF_firtsEntities1 db = new DB_EF_firtsEntities1())
            {
                db.tblProducts.Add(tblProduct);
                db.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public ActionResult Allproduct() {
            DB_EF_firtsEntities1 db = new DB_EF_firtsEntities1();
            List<tblProduct> products = db.tblProducts.ToList();
            return View(products);
        }
    }
}