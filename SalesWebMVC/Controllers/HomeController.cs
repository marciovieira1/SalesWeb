using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web App - Primeiro aplicativo C# - MVC.";
            ViewData["Developer"] = "Márcio Vieira de Souza";
            ViewData["email"] = "marcio.vieira1@gmail.com";
            ViewData["Cell_Phone"] = "(11) 98206.1336 (WhatsApp)";
            ViewData["git"] = "https://github.com/marciovieira1/SalesWeb";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Sales Web App - Primeiro aplicativo C# - MVC.";
            ViewData["Developer"] = "Márcio Vieira de Souza";
            ViewData["email"] = "marcio.vieira1@gmail.com";
            ViewData["Cell_Phone"] = "(11) 98206.1336 (WhatsApp)";
            ViewData["git"] = "https://github.com/marciovieira1/SalesWeb";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
