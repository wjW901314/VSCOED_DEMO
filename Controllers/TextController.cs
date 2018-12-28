using System.Collections.Generic;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
namespace VSCOED_DEMO.Controllers
{
    public class TextController : Controller
    {
        private IActionResult Index()
        {
            return View();
        }
    }
}