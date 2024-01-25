using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers;

public class Bai1Controller : Controller
{

    public IActionResult Index()
    {
        DateTime currentDate = DateTime.Now;
        string currentDateString = currentDate.ToString();
        return View((object)currentDateString);
    }
    public IActionResult Welcome(string name){
        string message = "Xin chào " + name;
        return View((object)message);
    }

}
