using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;

public class Bai2Controller : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Receive(string username)
    {
        ViewBag.Message = $"Xin chào {username}, bạn đã đăng ký thành công";
        return View("ResultRegister");
    }

    
}
