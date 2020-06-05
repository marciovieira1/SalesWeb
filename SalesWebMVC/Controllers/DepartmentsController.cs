using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Ferramentas" });
            list.Add(new Department { Id = 2, Name = "Tecnologia" });
            list.Add(new Department { Id = 3, Name = "Eletrônicos" });
            return View(list);
        }
    }
}
