using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC05.ViewModel
{
    public class HangHoaViewModel
    {
        public string sTenhang { get; set; }
        public double fGianiemyet { get; set; }
        public string sDacdiem { get; set; }
        public string sXuatxu { get; set; }
        public HttpPostedFileBase Anhminhhoa { get; set; }
    }
}