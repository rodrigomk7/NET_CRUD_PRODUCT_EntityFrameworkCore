using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcProduc.Models;

namespace mvcProduc.Controllers;

public class DemoController : Controller
{

    public IActionResult Index()
    {
         ViewBag.Message = "Hola estoy en el controlador de demo";
        return View();
    }

     public IActionResult Index2()
    {
         ViewBag.Message = "Hola estoy en index2 del controlador de demo";
        return View();
    }
}