

using MVC05.Models;
using MVC05.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC05.Controllers
{
    public class HangHoaController : Controller
    {
        // GET: HangHoa
        public ActionResult ThemHangHoa()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemHangHoa(HangHoaViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Anhminhhoa != null && model.Anhminhhoa.ContentLength > 0)
                {
                    //Upload ảnh minh hoạ lên server
                    var fileName = Path.GetFileName(model.Anhminhhoa.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    model.Anhminhhoa.SaveAs(path);

                    //Lưu thông tin hàng hoá vào sql server
                    var hanghoa = new tblHanghoa
                    {
                        sTenhang = model.sTenhang,
                        fGianiemyet = model.fGianiemyet,
                        sDacdiem = model.sDacdiem,
                        sXuatxu = model.sXuatxu,
                        sAnhminhhoa = fileName

                    };
                    db_Shop4TrainingEntities db = new db_Shop4TrainingEntities();
                    db.tblHanghoas.Add(hanghoa);
                    db.SaveChanges();
                    return RedirectToAction("getListHangHoa");
                    
                    

                }
            }
            return View(model);
        }
        public ActionResult getListHangHoa()
        {
            using(var db = new db_Shop4TrainingEntities())
            {

                List<tblHanghoa> hanghoas = db.tblHanghoas.ToList();
                return View(hanghoas);
            }
            
        }
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            using (var db =  new db_Shop4TrainingEntities())
            {
                List<tblChitiethoadon> tblChitiethoadon = db.tblChitiethoadons.Where(row => row.FK_iHanghoaID == id).ToList();
                db.tblChitiethoadons.RemoveRange(tblChitiethoadon);
                db.SaveChanges();

                tblHanghoa tblHanghoa = db.tblHanghoas.Where(row => row.PK_iHanghoaID == id).FirstOrDefault();
                db.tblHanghoas.Remove(tblHanghoa);
                db.SaveChanges();
                return Json(new { success = id });

            }
            
            
            
        }
        public ActionResult ListHangHoa()
        {
            db_Shop4TrainingEntities db = new db_Shop4TrainingEntities();
            List<tblHanghoa> tblHanghoas = db.tblHanghoas.ToList() ;
            return View(tblHanghoas);
        }
        public ActionResult FilterHangHoa(string name)
        {
            db_Shop4TrainingEntities db = new db_Shop4TrainingEntities();
            List<tblHanghoa> tblHanghoas = db.tblHanghoas.Where(x => x.sTenhang.Contains(name)).ToList();
            return PartialView("_productListPartial",tblHanghoas);
        }
        [HttpPost]
        public ActionResult addtoCarts(int hanghoaID)
        {
            try
            {
                db_Shop4TrainingEntities db = new db_Shop4TrainingEntities();
                var existingCart = db.carts.FirstOrDefault(x => x.fk_iHangHoaID == hanghoaID);
                if (existingCart != null)
                {
                    existingCart.iSL = existingCart.iSL + 1;
                    db.SaveChanges();
                    
                }
                else
                {
                    var cart = new cart
                    {
                        fk_iHangHoaID = hanghoaID,
                        iSL = 1


                    };
                    db.carts.Add(cart);
                    db.SaveChanges();

                }
                
                return Json(new { success = true, message = "Thêm thành công sản phẩm vào giỏ hàng" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Đã có lỗi xảy ra" });

            }
            
        }

        
    }
}