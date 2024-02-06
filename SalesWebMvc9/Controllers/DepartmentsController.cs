using Microsoft.AspNetCore.Mvc;
using SalesWebMvc9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc9.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Computers" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
