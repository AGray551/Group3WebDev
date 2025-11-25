using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppFinal.Models;

namespace WebAppFinal.Controllers;

public class HomeController : Controller {
    
    public IActionResult Index() {
        return View();
    }

    public IActionResult EricAbout() {
        return View("EricAbout");
    }
}