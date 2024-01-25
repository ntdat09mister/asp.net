using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC04.Models;

namespace MVC04.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult NewProduct()
        {
            DB_EF_firtsEntities1 db = new DB_EF_firtsEntities1();
            List<tblProduct> products = db.tblProducts.ToList();
            return View(products);
        }
    }
}