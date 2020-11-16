using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            list.Add(new Department { Id = 3, Name = "TI" });
            list.Add(new Department { Id = 4, Name = "RH" });
            list.Add(new Department { Id = 5, Name = "Finance" });
            list.Add(new Department { Id = 6, Name = "Production" });
            list.Add(new Department { Id = 7, Name = "Development" });
            list.Add(new Department { Id = 8, Name = "Reception" });
            list.Add(new Department { Id = 9, Name = "Director" });
            list.Add(new Department { Id = 10, Name = "Burning" });

            return View(list);
        }
    }
}
