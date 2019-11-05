using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fist.Aplication.MVC.Models;

namespace Fist.Aplication.MVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronico" });
            list.Add(new Departament { Id = 2, Name = "cama" });
            list.Add(new Departament { Id = 3, Name = "banho" });
            list.Add(new Departament { Id = 4, Name = "moveis" });
            list.Add(new Departament { Id = 5, Name = "celulares" });
            list.Add(new Departament { Id = 6, Name = "fogao" });

            return View(list);
        }
    }
}