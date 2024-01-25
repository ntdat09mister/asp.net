using MVC05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC05.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult getListCart()
        {
            db_Shop4TrainingEntities db = new db_Shop4TrainingEntities();
            List<cart> carts = db.carts.ToList();
            int soluong = carts?.Sum(x => x.iSL) ?? 0;
            Session["SLCart"] = soluong;
            return View(carts);
        }
        
    }
}