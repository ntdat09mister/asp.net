//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC05.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblChitiethoadon
    {
        public int FK_iHoadonID { get; set; }
        public int FK_iHanghoaID { get; set; }
        public int iSoluong { get; set; }
        public double fGiaban { get; set; }
    
        public virtual tblHanghoa tblHanghoa { get; set; }
        public virtual tblHoadon tblHoadon { get; set; }
    }
}
